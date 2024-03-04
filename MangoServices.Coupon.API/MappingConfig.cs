using System;
using AutoMapper;
using MangoServices.Coupon.API.Models.Dto;

namespace MangoServices.Coupon.API.Models
{
	public class MappingConfig
	{
		public static MapperConfiguration RegisterMaps()
		{
			var mappingConfig = new MapperConfiguration(config =>
			{
				config.CreateMap<CouponDto, Coupon>();
				config.CreateMap<Coupon, CouponDto>();
			});
			return mappingConfig;
		}
	}
}

