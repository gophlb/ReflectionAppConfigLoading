using Filters;
using ReflectionLoading.Configuration;
using System;
using System.Configuration;
using System.Reflection;

namespace ReflectionLoading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FilterSection connectionManagerDataSection = ConfigurationManager.GetSection(FilterSection.SectionName) as FilterSection;
            
            if (connectionManagerDataSection != null)
            {
                string stringToFilter = "a-13-fsv_5A!!__$_/";
                IFilter filter;
                Assembly assembly;
                Type filterType;

                Console.WriteLine(String.Format("Original string: {0}", stringToFilter));

                foreach (FilterElement filterElement in connectionManagerDataSection.Filters)
                {
                    try
                    {
                        assembly = Assembly.Load(filterElement.Assembly);
                        filterType = assembly.GetType(filterElement.FullPathClass);
                        filter = Activator.CreateInstance(filterType) as IFilter;

                        if (filter != null) 
                        { 
                            stringToFilter = filter.Filter(stringToFilter);                             
                            Console.WriteLine(String.Format("{0}: {1}", filterElement.Name, stringToFilter));
                        }
                        else { Console.WriteLine(String.Format("There was an error while building the filter {0}", filterElement.Name)); }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(String.Format("There was an error with filter {0}: {1}", filterElement.Name, ex.Message));
                    }
                }

                Console.ReadKey();
            }
        }
    }
}
