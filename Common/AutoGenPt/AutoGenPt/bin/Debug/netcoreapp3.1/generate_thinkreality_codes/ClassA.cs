//Template auto generator:[AutoGenPt] v1.0
//Creation time:2021/6/30 11:58:47
using System;
using System.Collections;
using System.Collections.Generic;
namespace Lenovo.XR.Development.Net.Pt
{
public class ClassA
{
    public byte __tag__ { get;private set;}

	public uint EntityId{ get;private set;}
	   
    public ClassA SetEntityId(uint value){EntityId=value; __tag__|=1; return this;}
	
    public bool HasEntityId(){return (__tag__&1)==1;}
	
    public static byte[] Write(ClassA data)
    {
        using(ByteBuffer buffer = new ByteBuffer())
        {
            buffer.WriteByte(data.__tag__);
			if(data.HasEntityId())buffer.WriteUInt32(data.EntityId);
			
            return buffer.Getbuffer();
        }
    }

    public static ClassA Read(byte[] bytes)
    {
        using(ByteBuffer buffer = new ByteBuffer(bytes))
        {
            ClassA data = new ClassA();
            data.__tag__ = buffer.ReadByte();
			if(data.HasEntityId())data.EntityId = buffer.ReadUInt32();
			
            return data;
        }       
    }
}
}
