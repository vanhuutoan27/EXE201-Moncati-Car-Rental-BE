﻿using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.SeedWorks;

namespace MocatiCar.Core.Repository
{
    public interface IModelRepository : IRepositoryBase<Model, Guid>
    {
        Task<IEnumerable<Model>> GetAllModelAsync(int page, int limit, string searchName);
        Task<Model> GetModelById(Guid id);
        void UpdateModel(Guid id, Model model);
        Task<IEnumerable<Model>> GetModelByBrandId(Guid brandId);
        Task<IEnumerable<Model>> GetModelByBrandName(string name);
        Task<bool> CheckModelNameExist(string modelName);
        Task<int> GetTotalModelCountAsync(string search);
        //Task<int> GetTotalModelCountBySearchAsync(string search);
        Task<Model> GetModelByNameAndBrandIdAsync(string modelName, Guid brandId);
    }
}
