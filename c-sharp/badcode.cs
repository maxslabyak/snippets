public class badcode
{
    private void DoSomething()
    {
      var alwaysTrue = true;
      
      while(!alwaysTrue)
      {
          //this will never be seen
      }
    }
}
