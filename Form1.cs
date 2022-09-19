using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {
        string tipo;
        string valor;
        // Lista deelementos que seran preguntados en el programa
        public List<string> trabajos = new List<string> {"Herrero", "Mercader", "Guerrero", "Clerigo", "Mago", "Lider", "Guardia"};
        public List<string> especies = new List<string> { "Humano", "Dios", "Animal", "Semihumano", "Hueco", "Gigante" };
        public List<string> genero = new List<string> { "Femenino", "Masculino" };
        public List<Personaje> personajes = new List<Personaje>();

        public Form1()
        {
            InitializeComponent();
            lblRespuesta.Visible = false;
            tipo = "genero";
            this.CambiarValor(tipo);
            this.CambiarPregunta(tipo, valor);
            // Lista de personajes
            personajes.Add(new Personaje {nombre = "Alvina", especie = "Animal", genero = "Femenino", trabajo = "Lider" });
            personajes.Add(new Personaje {nombre = "Anastacia", especie = "Humano", genero = "Femenino", trabajo = "Guardia" });
            personajes.Add(new Personaje {nombre = "Andre", especie = "Humano", genero = "Masculino", trabajo = "Herrero" });
            personajes.Add(new Personaje {nombre = "Luna Oscura", especie = "Humano", genero = "Femenino", trabajo = "Guerrero" });
            personajes.Add(new Personaje {nombre = "Princesa Anochecer", especie = "Humano", genero = "Femenino", trabajo = "Lider" });
            personajes.Add(new Personaje {nombre = "Lautrec", especie = "Humano", genero = "Masculino", trabajo = "Guerrero" });
            personajes.Add(new Personaje {nombre = "Cuervo", especie = "Animal", genero = "Masculino", trabajo = "Lider" });
            personajes.Add(new Personaje {nombre = "Domhnall", especie = "Humano", genero = "Masculino", trabajo = "Mercader" });
            personajes.Add(new Personaje {nombre = "Framth", especie = "Animal", genero = "Masculino", trabajo = "Lider" });
            personajes.Add(new Personaje {nombre = "Kaathe", especie = "Animal", genero = "Masculino", trabajo = "Lider" });
            personajes.Add(new Personaje {nombre = "Griggs", especie = "Humano", genero = "Masculino", trabajo = "Mago" });
            personajes.Add(new Personaje {nombre = "Logan", especie = "Humano", genero = "Masculino", trabajo = "Mago" });
            personajes.Add(new Personaje {nombre = "Guerrero Alicaido", especie = "Humano", genero = "Masculino", trabajo = "Guerrero" });
            personajes.Add(new Personaje {nombre = "Gwyndolin", especie = "Dios", genero = "Masculino", trabajo = "Mago" });
            personajes.Add(new Personaje {nombre = "Gwynevere", especie = "Dios", genero = "Femenino", trabajo = "Lider" });
            personajes.Add(new Personaje {nombre = "Gwyn", especie = "Hueco", genero = "Masculino", trabajo = "Guerrero" });
            personajes.Add(new Personaje {nombre = "Dama Blanca", especie = "Semihumano", genero = "Femenino", trabajo = "Lider" });
            personajes.Add(new Personaje {nombre = "Herrero Gigante", especie = "Gigante", genero = "Masculino", trabajo = "Herrero" });
            personajes.Add(new Personaje {nombre = "Ingward", especie = "Humano", genero = "Masculino", trabajo = "Mago" });
            personajes.Add(new Personaje {nombre = "Laurentius", especie = "Humano", genero = "Masculino", trabajo = "Mercader" });
            personajes.Add(new Personaje {nombre = "Mercader Alicaido", especie = "Humano", genero = "Masculino", trabajo = "Mercader" });
            personajes.Add(new Personaje {nombre = "Mercader no muerto", especie = "Hueco", genero = "Masculino", trabajo = "Mercader" });
            personajes.Add(new Personaje {nombre = "Mercader no muerta", especie = "Humano", genero = "Femenino", trabajo = "Mercader" });
            personajes.Add(new Personaje {nombre = "Oscar", especie = "Humano", genero = "Masculino", trabajo = "Guerrero" });
            personajes.Add(new Personaje {nombre = "Quellag", especie = "Semihumano", genero = "Femenino", trabajo = "Lider" });
            personajes.Add(new Personaje {nombre = "Oswald", especie = "Humano", genero = "Masculino", trabajo = "Clerigo" });
            personajes.Add(new Personaje {nombre = "Parches", especie = "Humano", genero = "Masculino", trabajo = "Mercader" });
            personajes.Add(new Personaje {nombre = "Petrus", especie = "Humano", genero = "Masculino", trabajo = "Clerigo" });
            personajes.Add(new Personaje {nombre = "Rhea", especie = "Humano", genero = "Femenino", trabajo = "Guardia" });
            personajes.Add(new Personaje {nombre = "Priscila", especie = "Semihumana", genero = "Femenino", trabajo = "Lider" });
            personajes.Add(new Personaje {nombre = "Quelana", especie = "Humano", genero = "Femenino", trabajo = "Mago" });
            personajes.Add(new Personaje {nombre = "Rickert", especie = "Humano", genero = "Masculino", trabajo = "Herrero" });
            personajes.Add(new Personaje {nombre = "Sieglinde", especie = "Humano", genero = "Femenino", trabajo = "Guerrero" });
            personajes.Add(new Personaje {nombre = "Siegmeyer", especie = "Humano", genero = "Masculino", trabajo = "Guerrero" });
            personajes.Add(new Personaje {nombre = "Solaire", especie = "Humano", genero = "Masculino", trabajo = "Guerrero" });
            personajes.Add(new Personaje {nombre = "Vamos", especie = "Hueco", genero = "Masculino", trabajo = "Herrero" });
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (radSI.Checked)
            {
                this.CambiarTipo(tipo);
                this.CambiarValor(tipo);
                this.CambiarPregunta(tipo, valor);
            }
            else
            {
                this.CambiarValor(tipo);
                this.CambiarPregunta(tipo, valor);
            }
        }

        public void CambiarTipo(string pregunta)
        {
            switch (pregunta)
            {
                case "genero":
                    // Quita los personajes que ya no son posibles...
                    personajes.RemoveAll(x => x.genero != valor);

                    // Quita los trabajos que ya no son posibles...
                    List<string> trabajosPosibles = (from p in personajes select p.trabajo).ToList();
                    trabajos.RemoveAll(trabajo => !trabajosPosibles.Contains(trabajo));

                    // Quita las especies que ya no son posibles...
                    List<string> especiesPosibles = (from p in personajes select p.especie).ToList();
                    especies.RemoveAll(especie => !especiesPosibles.Contains(especie));

                    tipo = "trabajo";
                    break;
                case "trabajo":
                    // Quita los personajes que ya no son posibles...
                    personajes.RemoveAll(x => x.trabajo != valor);

                    // Quita las especies que ya no son posibles...
                    List<string> especiesPosibles2 = (from p in personajes select p.especie).ToList();
                    especies.RemoveAll(especie => !especiesPosibles2.Contains(especie));

                    tipo = "especie";
                    break;
                case "especie":
                    // Quita los personajes que ya no son posibles...
                    personajes.RemoveAll(x => x.especie != valor);

                    tipo = "personaje";
                    break;
                case "personaje":
                    MessageBox.Show("Personaje Encontrado", "Wow");
                    Application.Exit();
                    break;
            }
        }
        
        public void CambiarValor(string pregunta)
        {
            switch (pregunta)
            {
                case "genero":
                    genero.Remove(valor);
                    if (genero.Any())
                    {
                        valor = genero.Last();
                    }
                    else
                    {
                        lblRespuesta.Text = "No hay opciones encontradas ...";
                        lblRespuesta.Visible = true;
                    }
                    break;
                case "trabajo":
                    trabajos.Remove(valor);
                    if (trabajos.Any())
                    {
                        valor = trabajos.Last();
                    }
                    else
                    {
                        lblRespuesta.Text = "No hay mas trabajos encontrados ...";
                        lblRespuesta.Visible = true;
                    }
                    break;
                case "especie":
                    especies.Remove(valor);
                    if (especies.Any())
                    {
                        valor = especies.Last();
                    }
                    else
                    {
                        lblRespuesta.Text = "No hay mas especies encontradas ...";
                        lblRespuesta.Visible = true;
                    }
                    break;
                case "personaje":
                    personajes.RemoveAll(x => x.nombre.Equals(valor));
                    if (personajes.Any())
                    {
                        valor = personajes.Last().nombre;
                    }
                    else
                    {
                        lblRespuesta.Text = "No hay mas personajes ...";
                        lblRespuesta.Visible = true;
                    }
                    break;
            }
        }
        public void CambiarPregunta(string pregunta, string opcion)
        {
            switch (pregunta)
            {
                case "genero":
                    lblPregunta.Text = $"¿El genero de tu personaje es {opcion}?";
                    break;
                case "trabajo":
                    lblPregunta.Text = $"¿El trabajo de tu personaje es {opcion}?";
                    break;
                case "especie":
                    lblPregunta.Text = $"¿La especie de tu personaje es {opcion}?";
                    break;
                case "personaje":
                    lblPregunta.Text = $"¿Tu personaje es: {opcion}?";
                    break;
            }
        }
    }
}
