using System;

public class Test
{
	private int Mid;
	private int Final;

	public int MyMid { get; }=98
	
		/*get
		{
			return Mid;
		}
		set
		{
			if(value < 0 || value > 100)
			{
				Mid = 0;
			}
			else
			{
				Mid = value;
			}
		}*/
	

	public int MyFinal
	{
		get
		{
			return Final;
		}
		set
		{
			if (value > 0 || value < 100)
			{
				Final = value;
			}
			else
			{
				Final = 0;
			}
		}
	}













}
