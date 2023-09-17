using BuberBreakfast.Models;
using ErrorOr;

namespace BuberBreakfast.Services.Breakfasts;

public interface IBreakfastService
{
    ErrorOr<Breakfast> GetBreakfast(Guid id);
    void CreateBreakfast(Breakfast breakfast);
    void UpsertBreakfast(Breakfast breakfast);
    void DeleteBreakfast(Guid id);
}