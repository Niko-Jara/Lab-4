using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.Clases;

namespace CapaDatos
{
    public  class GestionBd
    {
        List<Detfact> listadoTools;
        public List<Detfact> listadoFactura()
        {
            listadoTools = new List<Detfact>();
            Detfact objFact = new Detfact();

            //RELLENAMOS DATA
            objFact = new Detfact() { idFactura = Convert.ToInt32("123"), numLinea = Convert.ToInt32("001"), codProducto = "A1B1", detProducto = "Zapato", cantProducto = Convert.ToInt32("1"), costUnitario = Convert.ToDouble("12,500"), totalLinea = Convert.ToDouble("12,500") };
            listadoTools.Add(objFact);
            objFact = new Detfact() { idFactura = Convert.ToInt32("346"), numLinea = Convert.ToInt32("002"), codProducto = "B23B", detProducto = "Camisa", cantProducto = Convert.ToInt32("1"), costUnitario = Convert.ToDouble("5,000"), totalLinea = Convert.ToDouble("5,000") };
            listadoTools.Add(objFact);
            objFact = new Detfact() { idFactura = Convert.ToInt32("543"), numLinea = Convert.ToInt32("003"), codProducto = "CD34", detProducto = "Tennis", cantProducto = Convert.ToInt32("1"), costUnitario = Convert.ToDouble("4,500"), totalLinea = Convert.ToDouble("4,500") };
            listadoTools.Add(objFact);
            objFact = new Detfact() { idFactura = Convert.ToInt32("126"), numLinea = Convert.ToInt32("004"), codProducto = "A4R4", detProducto = "Reloj", cantProducto = Convert.ToInt32("1"), costUnitario = Convert.ToDouble("10,000"), totalLinea = Convert.ToDouble("10,000") };
            listadoTools.Add(objFact);
            objFact = new Detfact() { idFactura = Convert.ToInt32("342"), numLinea = Convert.ToInt32("005"), codProducto = "P451", detProducto = "Medias", cantProducto = Convert.ToInt32("2"), costUnitario = Convert.ToDouble("5,000"), totalLinea = Convert.ToDouble("10,000") };
            listadoTools.Add(objFact);
            objFact = new Detfact() { idFactura = Convert.ToInt32("129"), numLinea = Convert.ToInt32("006"), codProducto = "AR45", detProducto = "Licras", cantProducto = Convert.ToInt32("3"), costUnitario = Convert.ToDouble("7,500"), totalLinea = Convert.ToDouble("22,500") };
            listadoTools.Add(objFact);

            listadoTools.Add(objFact);
            return listadoTools;

        }
    }
}
