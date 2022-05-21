using AutoMapper;
using SimpleMathOperationsAPI.DTO;
using SimpleMathOperationsAPI.Entities;

namespace SimpleMathOperationsAPI.MappingProfiles
{
    public class MathOperationsProfile: Profile
    {
        public MathOperationsProfile()
        {
            CreateMap<MathOperation, MathOperationResponse>().ForMember((dest) => dest.MathOperator,
                opt => opt.MapFrom(src => src.Operator.ToString()));
        }
    }
}
