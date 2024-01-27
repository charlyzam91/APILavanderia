namespace ApiLavanderia.Modelos
{
    public class MLUsuarios
    {
        public int KeyUser{ get; set; }
        public String Nick { get; set; }
        public String Secreto { get; set; }
        public DateTime FechaRegistro { get; set; }
        public  Boolean activo { get; set; }
        
    }
}
