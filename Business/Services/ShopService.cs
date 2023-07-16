using Business.Models;
using DataAccess.Entities;
using DataAccess.Filter;
using DataAccess.Repositories;

namespace Business.Services
{
    public class ShopService
    {
        ShopRepository shopRepository = new ShopRepository();

        public Shop GetShopById(int shopId)
        {
            return shopRepository.GetShopById(shopId);
        }

        public List<Shop> getAllShop()
        {
            return shopRepository.getAllShop();
        }

        public bool AddShop(ShopModel shop)
        {
            var getShopById = shop.ShopId;

            if (getShopById > 0)
            {
                return false;
            }
            var entityShop = new Shop()
            {
                Name = shop.Name,
                IsProspection = shop.IsProspection,
                FirstPhone = shop.FirstPhone,
                IsWhatsappFirstPhone = shop.IsWhatsappFirstPhone,
                ImageId = shop.ImageId,
                GpsLongigtude = shop.GpsLongigtude,
                GpsLatitude = shop.GpsLatitude,
                DistrictId = shop.DistrictId,
                SecondPhone = shop.SecondPhone,
                IsWhatsappSecondPhone = shop.IsWhatsappSecondPhone,
                CreatingDate = shop.CreatingDate,
                JoiningDate = shop.JoiningDate,
            };
            shopRepository.AddShop(entityShop);
            return true;
        }

        public bool DeleteShop(int id)
        {
            var getShopById = shopRepository.GetShopById(id);
            if (getShopById is null)
            {
                return false;
            }
            shopRepository.DeleteShop(id);
            return true;
        }

        public bool UpdateShop(ShopModel shop)
        {
            var getShop = shopRepository.GetShopById(shop.ShopId);
            if (getShop is null)
            {
                return false;
            }
            getShop.Name = shop.Name;
            getShop.IsProspection = shop.IsProspection;
            getShop.FirstPhone = shop.FirstPhone;
            getShop.IsWhatsappFirstPhone = shop.IsWhatsappFirstPhone;
            getShop.ImageId = shop.ImageId;
            getShop.GpsLongigtude = shop.GpsLongigtude;
            getShop.GpsLatitude = shop.GpsLatitude;
            getShop.DistrictId = shop.DistrictId;
            getShop.SecondPhone = shop.SecondPhone;
            getShop.IsWhatsappSecondPhone = shop.IsWhatsappSecondPhone;
            getShop.CreatingDate = shop.CreatingDate;
            getShop.JoiningDate = shop.JoiningDate;

            shopRepository.UpdateShop(getShop);
            return true;
        }

        public List<ShopModel> Filter(FilterShopModel filter)
        {
            var convertFilterModelToEntity = new FilterShop()
            {
                NameShop = filter.NameShop,
                DistrictId = filter.DistrictId,
                IsProspection = filter.IsProspection,
                MinJoiningDate = filter.MinJoiningDate,
                MaxJoiningDate = filter.MaxJoiningDate,
                MinOrder = filter.MinOrder,
                MaxOrder = filter.MaxOrder,
                MinQuantityOfBag = filter.MinQuantityOfBag,
                MaxQuantityOfBag = filter.MaxQuantityOfBag,
            };
            var cast = shopRepository.Filter(convertFilterModelToEntity);
            return cast.Select(x => new ShopModel
            {
                CreatingDate = x.CreatingDate,
                JoiningDate = x.JoiningDate,
                DistrictId = x.DistrictId,
                FirstPhone = x.FirstPhone,
                GpsLatitude = x.GpsLatitude,
                GpsLongigtude = x.GpsLongigtude,
                ImageId = x.ImageId,
                IsProspection = x.IsProspection,
                IsWhatsappFirstPhone = x.IsWhatsappFirstPhone,
                IsWhatsappSecondPhone = x.IsWhatsappSecondPhone,
                Name = x.Name,
                ShopId = x.ShopId,
                SecondPhone = x.SecondPhone,
                NumberOfOrder = shopRepository.GetNumberOfOrder(x.ShopId),
                NumberOfBags = shopRepository.GetQuantityOfBags(x.ShopId),
            }).ToList();
        }
    }
}
