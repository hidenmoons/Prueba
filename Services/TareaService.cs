using webapi.Models;
namespace webapi.Services;

public class TareasService:ITareaServic
{
    TareasContext context;

    public TareasService(TareasContext dbcontext)
    {
        context = dbcontext;
    }

    public IEnumerable<Tarea> Get()
    {
        return context.Tareas;
    }

    public async Task Save(Tarea tarea)
    {
        context.Add(tarea);
        await context.SaveChangesAsync();
    }
    public async Task Update(Guid id, Tarea tarea)
    {
        var tareaActual = context.Tareas.Find(id);
        if (tareaActual != null)
        {
            tareaActual.TareaId = tarea.TareaId;
            tarea.Descripcion = tarea.Descripcion;
            tarea.Resumen = tarea.Resumen;

            await context.SaveChangesAsync();
        }

    }

        public async Task Delete(Guid id, Tarea tarea)
    {
        var tareaActual = context.Tareas.Find(id);
        if (tareaActual != null)
        {
            context.Remove(tareaActual);
            await context.SaveChangesAsync();

        }

    }
}

public interface ITareaServic
{
    IEnumerable<Tarea> Get();
    Task Update(Guid id, Tarea tarea);
    Task Delete(Guid id, Tarea tarea);
    Task Save(Tarea tarea);
}   