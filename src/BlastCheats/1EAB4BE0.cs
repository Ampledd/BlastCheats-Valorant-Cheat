using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000043 RID: 67
public static class 1EAB4BE0
{
	// Token: 0x06000366 RID: 870 RVA: 0x00E66B24 File Offset: 0x00E62F24
	public static int[] 7D004492(int 0D79029F)
	{
		IntPtr intPtr = IntPtr.Zero;
		int[] result;
		try
		{
			byte[] array = (IntPtr.Size == 4) ? 1EAB4BE0.67890FEA : 1EAB4BE0.64DC4176;
			intPtr = 474A1F71.37D96D4B(IntPtr.Zero, new UIntPtr((uint)array.Length), (474A1F71.1DC9365B)12288U, 474A1F71.575758F2.7DE035F4);
			Marshal.Copy(array, 0, intPtr, array.Length);
			1EAB4BE0.44903CCA 44903CCA = (1EAB4BE0.44903CCA)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(1EAB4BE0.44903CCA));
			GCHandle a = default(GCHandle);
			int[] array2 = new int[4];
			try
			{
				a = GCHandle.Alloc(array2, GCHandleType.Pinned);
				44903CCA(0D79029F, array2);
			}
			finally
			{
				if (a != default(GCHandle))
				{
					a.Free();
				}
			}
			result = array2;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				474A1F71.14C6408E(intPtr, 0U, 32768U);
			}
		}
		return result;
	}

	// Token: 0x06000367 RID: 871 RVA: 0x00E66C18 File Offset: 0x00E63018
	// Note: this type is marked as 'beforefieldinit'.
	static 1EAB4BE0()
	{
		byte[] array = new byte[30];
		RuntimeHelpers.InitializeArray(array, fieldof(000A3D2C.76714A05).FieldHandle);
		1EAB4BE0.67890FEA = array;
		byte[] array2 = new byte[26];
		RuntimeHelpers.InitializeArray(array2, fieldof(000A3D2C.69863BE5).FieldHandle);
		1EAB4BE0.64DC4176 = array2;
	}

	// Token: 0x040002D1 RID: 721
	private static readonly byte[] 67890FEA;

	// Token: 0x040002D2 RID: 722
	private static readonly byte[] 64DC4176;

	// Token: 0x0200004F RID: 79
	// (Invoke) Token: 0x06000404 RID: 1028
	private delegate void 44903CCA(int 3ED10BDA, int[] 4D1350A1);
}
