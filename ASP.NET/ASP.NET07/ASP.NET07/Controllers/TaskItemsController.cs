using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP.NET07.Data.Contexts;
using ASP.NET07.Models;
using ASP.NET07.Repository;

namespace ASP.NET07.Controllers
{
    public class TaskItemsController : Controller
    {
        TaskItemsRepository _taskItemRepository;

        public TaskItemsController()
        {
            _taskItemRepository = new TaskItemsRepository();
        }

        // GET: TaskItems
        public IActionResult Index()
        {
            return View(_taskItemRepository.GetAll());
        }

        // GET: TaskItems/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskItem = _taskItemRepository.GetById(id.Value);
            if (taskItem == null)
            {
                return NotFound();
            }

            return View(taskItem);
        }

        // GET: TaskItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TaskItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TaskItem taskItem)
        {
            if (ModelState.IsValid)
            {
                _taskItemRepository.Add(taskItem);
                _taskItemRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(taskItem);
        }

        // GET: TaskItems/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskItem = _taskItemRepository.GetById(id.Value);
            if (taskItem == null)
            {
                return NotFound();
            }
            return View(taskItem);
        }

        // POST: TaskItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, TaskItem taskItem)
        {
            if (id != taskItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _taskItemRepository.Update(taskItem);
                _taskItemRepository.Save();
               
                return RedirectToAction(nameof(Index));
            }
            return View(taskItem);
        }

        // GET: TaskItems/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taskItem = _taskItemRepository.GetById(id.Value);
            if (taskItem == null)
            {
                return NotFound();
            }

            return View(taskItem);
        }

        // POST: TaskItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var taskItem = _taskItemRepository.GetById(id);
            if (taskItem != null)
            {
                _taskItemRepository.Delete(taskItem);
            }

            _taskItemRepository.Save();
            return RedirectToAction(nameof(Index));
        }

    }
}
