using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrudEstudiantes.Data;
using CrudEstudiantes.Models;

namespace CrudEstudiantes.Controllers
{
    public class EstudiantesController : Controller
    {
        private readonly AppDbContext _context;

        public EstudiantesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Estudiantes
        public async Task<IActionResult> Index()
        {
            var estudiantes = await _context.Estudiantes.ToListAsync();
            return View(estudiantes);
        }

        // GET: Estudiantes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var estudiante = await _context.Estudiantes.FirstOrDefaultAsync(m => m.Id == id);
            if (estudiante == null)
                return NotFound();

            return View(estudiante);
        }

                // GET: Estudiantes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estudiantes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nombre,Apellido,Email,Matricula,FechaRegistro")] Estudiante estudiante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estudiante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estudiante);
        }

        // GET: Estudiantes/Edit/5
public async Task<IActionResult> Edit(int? id)
{
    if (id == null)
        return NotFound();

    var estudiante = await _context.Estudiantes.FindAsync(id);
    if (estudiante == null)
        return NotFound();

    return View(estudiante);
}

// POST: Estudiantes/Edit/5
[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Edit(int id,
    [Bind("Id,Nombre,Apellido,Email,Matricula,FechaRegistro")] Estudiante estudiante)
{
    if (id != estudiante.Id)
        return NotFound();

    if (ModelState.IsValid)
    {
        try
        {
            _context.Update(estudiante);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Estudiantes.Any(e => e.Id == id))
                return NotFound();
            else
                throw;
        }
        return RedirectToAction(nameof(Index));
    }
    return View(estudiante);
      }

      // GET: Estudiantes/Delete/5
public async Task<IActionResult> Delete(int? id)
{
    if (id == null)
        return NotFound();

    var estudiante = await _context.Estudiantes.FirstOrDefaultAsync(m => m.Id == id);
    if (estudiante == null)
        return NotFound();

    return View(estudiante);
}

// POST: Estudiantes/Delete/5
[HttpPost, ActionName("Delete")]
[ValidateAntiForgeryToken]
public async Task<IActionResult> DeleteConfirmed(int id)
{
    var estudiante = await _context.Estudiantes.FindAsync(id);
    if (estudiante != null)
    {
        _context.Estudiantes.Remove(estudiante);
        await _context.SaveChangesAsync();
    }
    return RedirectToAction(nameof(Index));
}
    }
}