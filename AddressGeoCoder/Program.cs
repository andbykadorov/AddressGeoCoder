using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geocoding.Google;
using Microsoft.SqlServer.Types;

namespace AddressGeoCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var geocoder = new GoogleGeocoder("AIzaSyDA2YCMlY-LGStW0m98KuLszdvF-TMEITo");

            try
            {
                using (var context = new Model1())
                {
                    var offerpadRecords = context.OfferPadOffers.ToList();
                    foreach (var offerPadOffer in offerpadRecords.Where(r => r.Address == "3011 S 2nd St Buckeye AZ 85326"))
                    {
                        var addresses = geocoder.Geocode(offerPadOffer.Address);
                        var bestMatch = addresses.FirstOrDefault();
                        if (bestMatch == null)
                            continue;
                        if (bestMatch.IsPartialMatch)
                            Debug.WriteLine("PARTIAL MATCH: " + offerPadOffer.Address);

                        var streetNumber =
                            bestMatch.Components.FirstOrDefault(c => c.Types.Contains(GoogleAddressType.StreetNumber))?
                                .LongName;
                        var street =
                            bestMatch.Components.FirstOrDefault(c => c.Types.Contains(GoogleAddressType.Route))?
                                .LongName;
                        offerPadOffer.CenterPointAddressLine1 = streetNumber + (!string.IsNullOrWhiteSpace(streetNumber) ? " " :
                        "") + street;

                        offerPadOffer.CenterPointCity = bestMatch.Components.FirstOrDefault(c => c.Types.Contains(GoogleAddressType.Locality))?
                                .LongName;
                        offerPadOffer.CenterPointRegion = bestMatch.Components.FirstOrDefault(c => c.Types.Contains(GoogleAddressType.AdministrativeAreaLevel2))?
                                .LongName;
                        offerPadOffer.CenterPointState = bestMatch.Components.FirstOrDefault(c => c.Types.Contains(GoogleAddressType.AdministrativeAreaLevel1))?
                                .ShortName;
                        offerPadOffer.CenterPointZip = bestMatch.Components.FirstOrDefault(c => c.Types.Contains(GoogleAddressType.PostalCode))?
                                .LongName;

                        offerPadOffer.CenterPointLatitude = bestMatch.Coordinates.Latitude;
                        offerPadOffer.CenterPointLongitude = bestMatch.Coordinates.Longitude;
                        var sqlGeography = SqlGeography.Point(bestMatch.Coordinates.Latitude,
                            bestMatch.Coordinates.Longitude, 4326);
                        offerPadOffer.CenterPointGeoLoc = DbGeography.FromText(sqlGeography.ToString(), 4326);
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}
