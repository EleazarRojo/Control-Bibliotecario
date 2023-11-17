namespace Control_Bibliotecario

{

    using System;

    public class Persona

    {
        public string RFC { get; set; }

        public string IdUsuario { get; set; }

        public string IdDeNivel { get; set; }

        public string Permisos { get; set; }

        public string Nombre { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public DateTime FechaDeNacimiento { get; set; }

        public int Edad { get; set; }

        public string Genero { get; set; }

        public void CrearRFC()
        {
            string yearString = FechaDeNacimiento.Year.ToString();
            RFC = ApellidoPaterno[0].ToString();

            for (int elemento = 1; elemento < ApellidoPaterno.Length; elemento++)

            {
                if ((ApellidoPaterno[elemento] == 'A') || (ApellidoPaterno[elemento] == 'E') || (ApellidoPaterno[elemento] == 'I')
                    || (ApellidoPaterno[elemento] == 'O') || (ApellidoPaterno[elemento] == 'U'))
                {
                    RFC += ApellidoPaterno[elemento].ToString();
                    break;
                }
            }

            RFC = RFC + ApellidoMaterno[0].ToString();
            RFC = RFC + Nombre[0].ToString(); //En este punto revisar si se creó una palabra no conveniente, si es así,
                                              //se sustituye Nombre[0].ToString(); por 'X'.ToString

            if (FechaDeNacimiento.Month < 10)
            {
                if (FechaDeNacimiento.Day >= 10)
                {
                    RFC = RFC + yearString[2].ToString() + yearString[3].ToString() + 0.ToString() + FechaDeNacimiento.Month.ToString() + FechaDeNacimiento.Day.ToString();
                }
                else
                {

                    RFC = RFC + yearString[2].ToString() + yearString[3].ToString() + 0.ToString() + FechaDeNacimiento.Month.ToString() + "0" + FechaDeNacimiento.Day.ToString();
                }

            }
            else
            {
                if (FechaDeNacimiento.Day >= 10)
                {
                    RFC = RFC + yearString[2].ToString() + yearString[3].ToString() + FechaDeNacimiento.Month.ToString() + FechaDeNacimiento.Day.ToString();

                }
                else
                {
                    RFC = RFC + yearString[2].ToString() + yearString[3].ToString() + FechaDeNacimiento.Month.ToString() + "0" + FechaDeNacimiento.Day.ToString();
                }
               
            }


        }






    }
}
