using System.Configuration;

namespace ReflectionLoading.Configuration
{
    public class FilterSection : ConfigurationSection
    {
        public const string SectionName = "FilterSection";
 
        private const string FiltersCollectionName = "Filters";
 
        [ConfigurationProperty(FiltersCollectionName)]
        [ConfigurationCollection(typeof(FiltersCollection), AddItemName = "add")]
        public FiltersCollection Filters { get { return (FiltersCollection)base[FiltersCollectionName]; } }
    }



    public class FiltersCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new FilterElement();
        }
        
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((FilterElement)element).FullPathClass;
        }
    }
 

    public class FilterElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get { return (string)this["name"]; }
            set { this["name"] = value; }
        }
        
        [ConfigurationProperty("assembly", IsRequired = true)]
        public string Assembly
        {
            get { return (string)this["assembly"]; }
            set { this["assembly"] = value; }
        }

        [ConfigurationProperty("fullPathClass", IsRequired = true)]
        public string FullPathClass
        {
            get { return (string)this["fullPathClass"]; }
            set { this["fullPathClass"] = value; }
        }
    }
}