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
            FilterSection filterDataSection = ConfigurationManager.GetSection(FilterSection.SectionName) as FilterSection;
            
            if (filterDataSection != null)
            {
                string stringToFilter = "a-13-fsv_5A!!__$_/";
                IFilter filter;
                Assembly assembly;
                Type filterType;

                Console.WriteLine(String.Format("Original string: {0}", stringToFilter));

                string message = "";
                foreach (FilterElement filterElement in filterDataSection.Filters)
                {
                    try
                    {
                        assembly = Assembly.Load(filterElement.Assembly);
                        filterType = assembly.GetType(filterElement.FullPathClass);
                        filter = Activator.CreateInstance(filterType) as IFilter;

                        if (filter != null)
                        {
                            stringToFilter = filter.Filter(stringToFilter);
                            message = String.Format("{0}: {1}", filterElement.Name, stringToFilter);
                        }
                        else { message = String.Format("There was an error while building the filter {0}", filterElement.Name); }
                    }
                    catch (Exception ex)
                    {
                        message = String.Format("There was an error with filter {0}: {1}", filterElement.Name, ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine(message);
                    }
                }

                Console.ReadKey();
            }
        }
    }
}
