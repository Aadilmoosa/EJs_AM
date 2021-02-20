namespace pa2_EJsimoneaux_1
{
    public class FireCharacter : Character
    {
       public FireCharacter()
        {
            
            SetAttackBehavior(new FireAttack());
            
        }
    }
}