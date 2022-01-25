namespace BassRigCurator.Models
{
    public class Combo
    {
        public Bass Bass { get; set; }
        public Amp  Amp { get; set; }

        public Combo(Bass bass, Amp amp)
        {
            Bass = bass;
            Amp = amp;
        }
    }
}
