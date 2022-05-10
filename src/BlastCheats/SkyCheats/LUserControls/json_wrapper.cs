using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace SkyCheats.LUserControls
{
	// Token: 0x0200002C RID: 44
	public class json_wrapper
	{
		// Token: 0x06000302 RID: 770 RVA: 0x0001FDD8 File Offset: 0x0001E1D8
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0001FDF8 File Offset: 0x0001E1F8
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(type);
			bool flag = !json_wrapper.is_serializable(type);
			if (flag)
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0001FE50 File Offset: 0x0001E250
		public object string_to_object(string json)
		{
			byte[] bytes = Encoding.Default.GetBytes(json);
			object result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = this.serializer.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0001FE9C File Offset: 0x0001E29C
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x0400023B RID: 571
		private DataContractJsonSerializer serializer;

		// Token: 0x0400023C RID: 572
		private object current_object;
	}
}
