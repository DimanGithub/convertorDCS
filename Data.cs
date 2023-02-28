public class Data
{
 byte[] data;
 public enum format {bin,bcd,dec,oct,hex};

  public Data()
  {
    data = new byte[]{155,255,255,255,255,255,255,0};
  }
  public void display(format format)
  {
     Console.WriteLine(format.ToString());
     switch(format)
     {
      
        case format.bin://binary format e.g. 00000000 111111111 
            string[] str =data.Select(x=>Convert.ToString(x,2).PadLeft(8,'0')).ToArray();
            foreach(var v in str)
            {
            Console.Write(v);
            Console.Write(" ");
            }
        break;

        case format.bcd://BCD format
        
           // data.Select(x=>x.this[int index]
          
        break;

        


      
     }
        
   
    
}
