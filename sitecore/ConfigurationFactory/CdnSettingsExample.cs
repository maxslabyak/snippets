namespace Image0.CDN
{
	public static class CdnSettingsExample
	{
		public string GetPath()
		{
			CountryCdnSettings settings = null;
            settings = CountryCdnSettings.Create();
            return settings != null ? settings.CdnPath : String.Empty;
		}
	}
}