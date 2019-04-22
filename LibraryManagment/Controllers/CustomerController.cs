using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagment.Data.Interfaces;
using LibraryManagment.Data.Model;
using LibraryManagment.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _CustomerRepository;
        private readonly IBookRepository _BookRepository;
        // create a Construnctor and inject there repository by service (DI)
        public CustomerController(ICustomerRepository CustomerRepository , IBookRepository BookRepository)
        {
            _CustomerRepository = CustomerRepository;
            _BookRepository = BookRepository;
        }
        [Route("Customer")]
        public IActionResult List()
        {
            var bookVm = new List<BookViewModel>();
            var CustomerVM = new List<CustomerViewModel>();
            var customers = _CustomerRepository.GetAll();
            if (customers.Count() == 0)
            {
                return View("Empty");
            }
            foreach (var customer in customers)
            {
                CustomerVM.Add(new CustomerViewModel
                {
                    Customer = customer,
                    BookCount = _BookRepository.Count(s => s.BorrownerId == customer.CustomerId)
                });
            }

            /// First or FirstorDefault and Single or SingleORDefault 

            ///At that Time If we Do not Get any Record Corresponding To Expression in Where Clause then It Will Throw You Exception as: InvalidOperationException: Sequence contains no elements.
            ///2.	When There Are Multiple Records Releted To TO Matching Expression and If You want only the First One Then You can Use First().
            ///3.	First() returns First Element Of Sequence.
            ///4.   First() throws Exception when There IS No element Presnt In Table

            var x = (from m in CustomerVM
                     where m.BookCount == 2000
                     select m.BookCount).First();
            //// We can handle this by using catch block
            //try
            //{
            //    var x1 = (from m in CustomerVM
            //             where m.BookCount == 2000
            //             select m.BookCount).First();
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //1.	When we Use FirstORDefault () in LINQ in Query Syntax Or Method Syntax, At that Time If we Do not Get any Record Corresponding To Criteria in Where Clause then It Will return Some Default Value (Null).
            //In The Member table There Is no Such Record Which Will Match the expression so Above Query will Return Default value as Null but Not An Exception.
            //2.	When There Are Multiple Records Releted To TO Matching Expression and If You want only the First One Then You can Use First().

            //var z = (from m in CustomerVM
            //         where m.Customer.CustomerId == 2
            //         select m.Customer.CustomerId).FirstOrDefault();


            // Single or singleordefault
            // Single () --There is exactly 1 result, an exception is thrown if no result is returned or more than one result. 
            //SingleOrDefault() – Same as Single(), but it can handle the null value.
            //Single() asserts that one and only one element exists in the sequence.
            //When to use
            // Use Single / SingleOrDefault() when you sure there is only one record present in database or you can say if you querying on database with help of primary key of table.	When to use
            //Developer may use First() / FirstOrDefault() anywhere,  when they required single value from collection or database.

            //To do a left outer join, you need SelectMany and DefaultIfEmpty, for example:

            //var query = from c in CustomerVM
            //            join o in bookVm
            //            on c.BookCount equals o.Book into sr
            //            from x in sr.DefaultIfEmpty()
            //            orderby c.customerid
            //            select new
            //            {
            //                customersID = c.customerid
            //            };


            /// Cross join 

            //var info = from stu in CustomerVM
            //           from cro in bookVm
            //           select new
            //           {
            //               stu.BookCount,
            //               stu.Customer,
            //               cro.Authors,
            //               cro.Book
            //           };

            return View(CustomerVM);
        }

        public IActionResult Delete (int id)
        {
            var customer = _CustomerRepository.GetById(id);
            _CustomerRepository.Delete(customer);
            return RedirectToAction("List");
        }

        public IActionResult Create()
        {
            return View();
        }

        //In this view we have to create a Post Request to Create A customer
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            _CustomerRepository.Create(customer);
            return RedirectToAction("List");
        }

        public IActionResult Update(int id)
        {
            var customer = _CustomerRepository.GetById(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Update(Customer customer)
        {
            _CustomerRepository.Update(customer);
            return RedirectToAction("List");
        }

    }
}
