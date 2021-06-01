using Parcial.Domain.Parcial.Data.Services;
using Parcial.Shared.Parcial.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial.Domain.Parcial.Business
{
    public class AfiliadoBiz
    {
        public void Agregar(Afiliado model)
        {
            var db = new BaseDataServices<Afiliado>();
            db.Create(model);
        }

        // Lista los elementos de la clase Usuario
        public List<Afiliado> Listar()
        {
            var Db = new BaseDataServices<Afiliado>();
            var Lista = Db.Get();
            return Lista;
        }

        public Afiliado BuscarId(int id)
        {
            var Db = new BaseDataServices<Afiliado>();
            var model = Db.GetById(id);
            return model;
        }

        public void Editar(Afiliado model)
        {
            var Db = new BaseDataServices<Afiliado>();
            Db.Update(model);
        }

        public void Delete(int id)
        {
            var Db = new BaseDataServices<Afiliado>();
            Db.Delete(id);
        }

    }
}