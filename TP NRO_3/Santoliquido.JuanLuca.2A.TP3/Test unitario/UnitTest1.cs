using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesAbstractas;
using Excepciones;
using ClasesInstanciables;


namespace Test_unitario
{
    [TestClass]
    public class UnitTest1
    {
       
           

            [TestMethod]
            [ExpectedException(typeof(AlumnoRepetidoException))]
            public void TestAlumnoRepetidoException()
            {
                Alumno a = new Alumno(1, "Eduardo", "Deluca", "15436875", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
                Alumno a1 = new Alumno(1, "roberto", "Lopez", "32145864", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion);
                Universidad u = new Universidad();
                u += a;
                u += a1;

                Assert.AreEqual(a, a1);
            }

            

            [TestMethod]
            public void SinProfesorException()
            {
                try
                {
                    Universidad u = new Universidad();
                    Profesor p = u == Universidad.EClases.Programacion;
                }
                catch (Exception e)
                {
                    Assert.IsInstanceOfType(e, typeof(SinProfesorException));
                }
            }
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void DniInvalidoException()
        {
            Alumno alumno = new Alumno(1, "Rodolfo", "tevez", "uno", Persona.ENacionalidad.Argentino, Universidad.EClases.SPD);

        }
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestNacionalidadInvalidaException()
        {
            Alumno alumno = new Alumno(1, "Dardo", "fuseneco", "900000000", Persona.ENacionalidad.Argentino, Universidad.EClases.SPD);

        }

        [TestMethod]
        public void TestValidaNotNull()
        {
            Universidad u = new Universidad();

            Assert.IsNotNull(u.Jornadas);
        }

        [TestMethod]
        public void TestJornadaNotNull()
        {
            Profesor profesor = new Profesor(1, "Dardo", "fuseneco", "45826536", Persona.ENacionalidad.Argentino);
            Jornada jornada = new Jornada(Universidad.EClases.SPD, profesor);

            Assert.IsNotNull(jornada.Alumnos);
        }


    }
}

