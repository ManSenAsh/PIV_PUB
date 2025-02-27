using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIV_PUB
{
    class Diario
    {
        private string vistas;
        private string contrsela;

        public Diario(string VistaDeDiario)
        {
            vistas = VistaDeDiario;
        }
        public void contrseña(string Contra)
        {
            Contra = Console.ReadLine();
            contrsela = Contra;

            Console.WriteLine("nueva contraseña puesta");

        }
        public void verificar(string VerifCon)
        {
            VerifCon = Console.ReadLine();
            while (VerifCon != contrsela)
            {
                Console.WriteLine("contraseña no correcta");
                VerifCon = Console.ReadLine();

            }

        }


        public void ingresarDato(string MeterDato)
        {
            MeterDato = Console.ReadLine();
            DateTime fecha = DateTime.Now;
            vistas = fecha + MeterDato;
            Console.WriteLine("registro guardado");
            Console.WriteLine(fecha + " " + MeterDato);



        }

        public void RetirarDato(string BorrarDato)
        {
            BorrarDato = " ";
            vistas = BorrarDato;
            Console.WriteLine("dato borrado");
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            bool sino = false;
            Diario ashter = new Diario("29");
            Console.WriteLine("ponga una consseña");
            ashter.contrseña("tangamandapio");

            Console.WriteLine("verifique");
            ashter.verificar("tangamandapio");
            Console.WriteLine("ponga un acontecimiento de su bida");
            ashter.ingresarDato("me cai ");
            Console.WriteLine("quiere borrar su dato poner, true o false");

            sino = bool.Parse(Console.ReadLine());
            if (sino == true)
            {
                ashter.RetirarDato("borrardato");

            }



                Console.ReadLine();
            }
        }

    }

