﻿using CRUD.Data;
using CRUD.Models;
using System.Collections.Generic;
using System.Linq;

namespace CRUD.Services
{
    public class SellerService
    {
        private readonly CRUDContext _context;

        public SellerService(CRUDContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}