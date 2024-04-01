﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FablabCatalagoVirtualCapasEN;

namespace FablabCatalagoVirtualCapasDAL
{
    public class MaterialesDAL
    {
        private static List<Materiales> listaMateriales = new List<Materiales>();

        public List<Materiales> regresarLista()
        {
            return listaMateriales;
        }
        public void guardarMaterial (Materiales pMateriales)
        {
            pMateriales.Id = listaMateriales.Select(listaMateriales => listaMateriales.Id).DefaultIfEmpty(1).Max() + 1;
            listaMateriales.Add(pMateriales);
        }
        public void actualizarMaterial (Materiales pMateriales)
        {
            var remover = listaMateriales.FirstOrDefault(i => i.Id == pMateriales.Id);
            listaMateriales.Add(pMateriales);
            listaMateriales.Remove(remover);
        }
        public void eliminarMateriales (Materiales pMateriales)
        {
            var eliminar = listaMateriales.FirstOrDefault(i => i.Id == pMateriales.Id);
            listaMateriales.Remove(eliminar);
        }
    }
}
    