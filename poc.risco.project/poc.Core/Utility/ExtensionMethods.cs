namespace poc.Core.Utility
{
    public static class ExtensionMethods
    {
        //public static string ToCamelCase(this string str) {
        //    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        //    return textInfo.ToTitleCase(str);
        //}

        //public static string ToCountryCode(this string countryName) {

        //    if (string.IsNullOrEmpty(countryName))
        //        return null;

        //    foreach (CultureInfo culture in CultureInfo.GetCultures(CultureTypes.AllCultures).Where(c => c.IsNeutralCulture == false)) {

        //        if (string.IsNullOrWhiteSpace(culture.Name) == true || string.IsNullOrWhiteSpace(culture.NativeName) == true)
        //            continue;

        //        RegionInfo region = new RegionInfo(culture.LCID);

        //        if (countryName.Equals(region.DisplayName, StringComparison.InvariantCultureIgnoreCase)
        //            || countryName.Equals(region.NativeName, StringComparison.InvariantCultureIgnoreCase)
        //            || countryName.Equals(region.EnglishName, StringComparison.InvariantCultureIgnoreCase)
        //            || countryName.Equals(region.Name, StringComparison.InvariantCultureIgnoreCase)
        //            || countryName.Equals(region.TwoLetterISORegionName, StringComparison.InvariantCultureIgnoreCase)
        //            || countryName.Equals(region.ThreeLetterISORegionName, StringComparison.InvariantCultureIgnoreCase)) {

        //            return region.Name;
        //        }
        //    }

        //    return string.Empty;
        //}

        ///// <summary>
        ///// Atualiza as propriedades com valor nulo na entidade alvo a partir da entidade fonte desde que tenham o mesmo nome.
        ///// </summary>
        ///// <param name="target">Entidade que terá suas propriedades nulas alteradas.</param>
        ///// <param name="source">Entidade que contém as informações a serem gravadas.</param>
        //public static void MergePropertyValues(this object target, object source) {

        //    if (target.GetType() != source.GetType()) { throw new ArgumentException("Type mismatch"); }

        //    try {

        //        List<PropertyInfo> targetProperties = target.GetType().GetRuntimeProperties()
        //            .Where(p => p.GetIndexParameters().Any() == false)
        //            .Where(p => p.CanRead && p.CanWrite).ToList();

        //        List<PropertyInfo> sourceProperties = source.GetType().GetRuntimeProperties()
        //            .Where(p => p.GetIndexParameters().Any() == false)
        //            .Where(p => p.CanRead && p.CanWrite)
        //            .Where(p => p.GetValue(source, null) != null).ToList();

        //        Parallel.ForEach(targetProperties, targetProperty => {

        //            if (targetProperty.GetValue(target, null) != null) { return; }

        //            foreach (PropertyInfo sourceProperty in sourceProperties) {

        //                if (targetProperty.Name != sourceProperty.Name || !targetProperty.PropertyType.GetTypeInfo().IsAssignableFrom(sourceProperty.PropertyType.GetTypeInfo())) { continue; }

        //                targetProperty.SetValue(target, sourceProperty.GetValue(source, new object[] { }), new object[] { });

        //                break;
        //            }
        //        });
        //    }
        //    catch (Exception e) { throw new Exception(e.ToString()); }
        //}
    }
}
