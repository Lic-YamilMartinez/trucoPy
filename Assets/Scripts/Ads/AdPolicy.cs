namespace TrucoPy.Ads
{
    // Solo decide elegibilidad. No implementa SDK ni solicita anuncios.
    public static class AdPolicy
    {
        public static bool CanShowInterstitial(bool hasInternet, bool consentAllowsAds,
            int completedMatchesSinceLastAd, int minimumMatchesBetweenAds = 2)
        {
            return hasInternet && consentAllowsAds &&
                completedMatchesSinceLastAd >= minimumMatchesBetweenAds;
        }
    }
}
