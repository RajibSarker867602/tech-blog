namespace TechBlog.Models.Common
{
    public static class ObjectClone
    {
        //public static T Clone<T>(T source)
        //{
        //    //if (!typeof(T).IsSerializable)
        //    //{
        //    //    throw new ArgumentException("The type must be serializable.", nameof(source));
        //    //}

        //    // Don't serialize a null object, simply return the default for that object
        //    if (ReferenceEquals(source, null)) return default;

        //    using (Stream stream = new MemoryStream())
        //    {
        //        IFormatter formatter = new BinaryFormatter();
        //        formatter.Serialize(stream, source);
        //        stream.Seek(0, SeekOrigin.Begin);
        //        return (T)formatter.Deserialize(stream);
        //    }
        //}

        //public static T CloneJson<T>(this T source)
        //{
        //    // Don't serialize a null object, simply return the default for that object
        //    if (ReferenceEquals(source, null)) return default;

        //    // initialize inner objects individually
        //    // for example in default constructor some list property initialized with some values,
        //    // but in 'source' these items are cleaned -
        //    // without ObjectCreationHandling.Replace default constructor values will be added to result
        //    var deserializeSettings = new JsonSerializerSettings { ObjectCreationHandling = ObjectCreationHandling.Replace };

        //    return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(source), deserializeSettings);
        //}

        //public static T CloneObject<T>(this T source)
        //{
        //    foreach (var prop in source.GetType().GetProperties())
        //    {
        //        var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
        //        var ds = prop.Name;
        //        var sl = prop.GetValue(source);
        //        //if (type == typeof(DateTime))
        //        //{
        //        //    Console.WriteLine(prop.GetValue(car, null).ToString());
        //        //}
        //    }

        //    return source;
        //}
    }

    public static class ListCopyHelper
    {
        public static List<T> DeepCopy<T>(List<T> sourceList) where T : ICloneable
        {
            if (sourceList == null)
                throw new ArgumentNullException(nameof(sourceList));

            // Create a new list and clone each element from the source list
            List<T> newList = new List<T>();

            foreach (T item in sourceList)
            {
                if (item == null)
                {
                    newList.Add(default(T));
                }
                else
                {
                    T clonedItem = (T)item.Clone();
                    newList.Add(clonedItem);
                }
            }

            return newList;
        }
    }
}