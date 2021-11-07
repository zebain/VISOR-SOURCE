using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace KeyAuth
{
	// Token: 0x02000004 RID: 4
	public class json_wrapper
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00003270 File Offset: 0x00001470
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003290 File Offset: 0x00001490
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

		// Token: 0x06000018 RID: 24 RVA: 0x000032E8 File Offset: 0x000014E8
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

		// Token: 0x06000019 RID: 25 RVA: 0x00003334 File Offset: 0x00001534
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x0400000B RID: 11
		private DataContractJsonSerializer serializer;

		// Token: 0x0400000C RID: 12
		private object current_object;
	}
}
