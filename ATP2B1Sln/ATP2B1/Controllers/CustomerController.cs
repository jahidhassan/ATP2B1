using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ATP2B1.Models;
using System.Data.Entity;
using ATP2B1.ViewModel;

namespace ATP2B1.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Detail(int? id)
        {
            Customer customer;
            if (id.HasValue)
            {
                customer = _context.Customers.FirstOrDefault(c => c.ID == id.Value);
                if (customer == null)
                    return HttpNotFound("Invalid Customer ID");
            }
            else
            {
                customer = new Customer();
            }

            var allMembershipTypes = _context.MembershipTypes.ToList();

            var vm = new DetailCustomerVM()
            {
                Customer = customer,
                MembershipTypes = allMembershipTypes
            };

            return View("Detail", vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Detail(Customer customer)
        {

            if (!ModelState.IsValid)
            {
                var vm = new DetailCustomerVM()
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };

                return View("Detail", vm);
            }

            if(customer.ID==0)
                _context.Customers.Add(customer);
            else
            {
                var objToSave = _context.Customers.FirstOrDefault(c => c.ID == customer.ID);

                if (objToSave == null)
                    return HttpNotFound("Invalid Customer ID");

                //ryUpdateModel(objToSave,"",new string[] {"Name","Birthdate"});

                objToSave.Name = customer.Name;
                objToSave.BirthDate = customer.BirthDate;
                objToSave.MobileNo = customer.MobileNo;
                objToSave.Gender = customer.Gender;
                objToSave.MembershipTypeID = customer.MembershipTypeID;
                objToSave.IsSubscribeToMail = customer.IsSubscribeToMail;
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.ID == id);
            if (customer == null)
                return HttpNotFound("Invalid Customer ID");

            _context.Customers.Remove(customer);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        // GET: Customer
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c=>c.MembershipType).ToList();
            return View(customers);
        }
    }
}