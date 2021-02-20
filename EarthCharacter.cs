namespace pa2_EJsimoneaux_1
{
    public class EarthCharacter : Character
    {
        public EarthCharacter()
        {
            
            SetAttackBehavior(new EarthAttack());
            
        }
    }
}