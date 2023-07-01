namespace SobreCargaFer01.Entidades
{
    public class Tiempo
    {
        private int _hora;
        private int _minutos;
        private int _segundos;
        //Sobrecarga de Constructores

        #region Constructores
        public Tiempo(int hora, int minutos, int segundos)
        {
            _hora = hora;
            _minutos = minutos;
            _segundos = segundos;
        }
        public Tiempo(int hora, int minutos) : this(hora, minutos, 59)
        {

        }
        public Tiempo(int hora) : this(hora, 59)
        {

        }

        #endregion 

        public void SetHora(int hora)
        {
            _hora = hora;
        }
        #region MostrarDatos
        public string MostrarDatos()
        {
            return $"{_hora.ToString().PadLeft(2,'0')}:{_minutos.ToString().PadLeft(2, '0')}:{_segundos.ToString().PadLeft(2, '0')}";
        }
        public string MostrarDatos(bool sinSegundos)
        {
            return $"{_hora.ToString().PadLeft(2, '0')}:{_minutos.ToString().PadLeft(2, '0')}";
        }
        #endregion

        public static bool operator ==(Tiempo t1, Tiempo t2)
        {
            return t1._hora==t2._hora &&
                t1._minutos==t2._minutos &&
                t1._segundos==t2._segundos;
        }
        public static bool operator !=(Tiempo t1, Tiempo t2)
        {
            return !(t1 == t2);
        }

        public static implicit operator int(Tiempo t)
        {
            return (t._hora * 60 + t._minutos) * 60 + t._segundos;
        }

        public static explicit operator Tiempo(string strHora)
        {
            string[] array = strHora.Split(':');
            int hora = int.Parse(array[0]);
            int minutos = int.Parse(array[1]);
            int segundos = int.Parse(array[2]);
            return new Tiempo(hora, minutos, segundos);
        }

        public static Tiempo operator +(Tiempo t1, Tiempo t2)
        {
            int segundosT1 = t1;
            int segundosT2 = t2;
                
            int segundos=segundosT1+ segundosT2;
            int hora = segundos / 3600;
            int minutos = (segundos - (hora * 3600)) / 60;
            int segundos2 = (segundos - (minutos * 60) - (hora * 3600));
            return new Tiempo(hora,minutos,segundos2);
        }
    }
}