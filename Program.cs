using System;

namespace ConsoleApp1_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 定义一个类的对象获取
            //Person p = new Person();
            //p.clothes = new Clothes() { Color = "red", Sized = "xxl" };
            //foreach (System.Reflection.PropertyInfo info in p.GetType().GetProperties())
            //{
            //    Console.WriteLine(info.Name);
            //}
            //// 获取描述属性的值
            //p.Name = "张三";
            //var name = p.GetType().GetProperty("clothes").GetValue(p, null);
            //Console.WriteLine(name);

            ////通过类获取
            //var properties = typeof(Person).GetProperties();
            //foreach (System.Reflection.PropertyInfo info in properties)
            //{
            //    Console.WriteLine(info.Name);
            //}

            // 继承,implement interface 相同的属性


        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool t { get; set; }
        public Clothes clothes { get; set; }

    }
    public class Clothes { 
    public string Color { get; set; }
        public string Sized { get; set; }
    }

    public class student:ITenantCommonModel, IEntity<Guid?>
    {
        public Guid Id { get; set; }

        public string name; 
    }
    public class ITenantCommonModel
    {
        /// <summary>
        /// 主键，GUID
        /// </summary>
        public Guid? Id { get; set; }
        //附件列表
    }

    /// <summary>
    /// Defines interface for base entity type. All entities in the system must implement this interface.
    /// </summary>
    /// <typeparam name="TPrimaryKey">Type of the primary key of the entity</typeparam>
    public interface IEntity<TPrimaryKey>
    {
        /// <summary>
        /// Unique identifier for this entity.
        /// </summary>
        TPrimaryKey Id { get; set; }
    }
}
