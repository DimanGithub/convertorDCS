public class Data
{
 byte[] data;
 public enum format {bin,bcd,dec,sdec,floa_t,hex};//binary,BCD,decimal,Signed Decimal,Floating Point, Hexadecimal,Text
 public enum size{one_byte,word,double_word,quad_word};// byte, word ,2 words, 4 words

public Int16 word0 {get{return BitConverter.ToInt16(new byte[]{data[1],data[0]},0);}}
public Int16 word1 {get{return BitConverter.ToInt16(new byte[]{data[3],data[2]},0);}}
public Int16 word2 {get{return BitConverter.ToInt16(new byte[]{data[5],data[4]},0);}}
public Int16 word3 {get{return BitConverter.ToInt16(new byte[]{data[7],data[6]},0);}} 

public UInt16 uword0 {get{return BitConverter.ToUInt16(new byte[]{data[1],data[0]},0);}}
public UInt16 uword1 {get{return BitConverter.ToUInt16(new byte[]{data[3],data[2]},0);}}
public UInt16 uword2 {get{return BitConverter.ToUInt16(new byte[]{data[5],data[4]},0);}}
public UInt16 uword3 {get{return BitConverter.ToUInt16(new byte[]{data[7],data[6]},0);}} 


  public Data()
  {
    data = new byte[]{0x00,0x1,0x00,0x2,0x00,0x003,0x00,0x04};//w0,w1,w2,w3,w4
    
  }
   
   public void display(format format,size size=size.word)
    {
     Console.WriteLine(format.ToString());
     switch(format)
     {
      
        case format.bin://display data in binary format e.g. 00000000 111111111 
            string[] str =data.Select(x=>Convert.ToString(x,2).PadLeft(8,'0')).ToArray();
            foreach(var v in str)
            {
            Console.Write(v);
            Console.Write(" ");
            }
        break;

        case format.bcd://display BCD format

           foreach(var v in data)
           {
            int high=v>>4;
            int low = v & 0xf;
            if (high>9||low>9) 
            {
               Console.Write("ERROR");
            }
            Console.Write((byte)(10 * high + low));
           }
          
        break;

        case format.dec://display data in decimal format
            if(size == size.word) 
            {
               
            }
           
        break;

     }
 
   }

public byte BinToBcd(byte bin)
{
   byte bcd;
   int high=bin>>4;
   int low = bin & 0xf;
   int result =10 * high + low;
   bcd = (byte)result;
   return bcd;
}

}
