using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MocatiCar.Core.Domain.Content;

namespace MoncatiCar.Data.Configurations
{
    public class CarFeatureConfiguration : IEntityTypeConfiguration<CarFeature>
    {
        public void Configure(EntityTypeBuilder<CarFeature> builder)
        {
            builder.HasData(new List<CarFeature>
            {
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635"),
                    FeatureId = Guid.Parse("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c")
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635"),
                    FeatureId = Guid.Parse("533a7038-190b-4830-8125-5d2aacb7174e")
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635"),
                    FeatureId = Guid.Parse("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635"),
                    FeatureId = Guid.Parse("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635"),
                    FeatureId =  Guid.Parse("be392eff-ef38-4039-94ec-7922f315ea6a"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635"),
                    FeatureId =  Guid.Parse("182612c2-4fbf-46d9-bee0-9e1a10c29ff5"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635"),
                    FeatureId =  Guid.Parse("e285ec6a-3119-43b5-8edb-209fa732a77d"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635"),
                    FeatureId =  Guid.Parse("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635"),
                    FeatureId = Guid.Parse("4481e46d-e85b-4870-a210-cdfea8932641"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635"),
                    FeatureId = Guid.Parse("25814c9e-4ee4-4f36-a973-44cf0cf64485"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635"),
                    FeatureId = Guid.Parse("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1")
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635"),
                    FeatureId = Guid.Parse("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635"),
                    FeatureId =  Guid.Parse("905d9d8f-7b09-4536-82d1-d15b938b2dac"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635"),
                    FeatureId =  Guid.Parse("defbc09e-9f00-49b9-a37e-592a17cecc63"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635"),
                    FeatureId =  Guid.Parse("057670f0-ab14-41bf-b5f0-42c0bdcc069c"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635"),
                    FeatureId = Guid.Parse("f761d066-304f-49f7-b988-3aca64536d9b"),
                },
                //car 2
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("95CF0585-B940-4AFB-926D-01D9A3A27259"),
                    FeatureId = Guid.Parse("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("95CF0585-B940-4AFB-926D-01D9A3A27259"),
                    FeatureId = Guid.Parse("533a7038-190b-4830-8125-5d2aacb7174e"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("95CF0585-B940-4AFB-926D-01D9A3A27259"),
                    FeatureId = Guid.Parse("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("95CF0585-B940-4AFB-926D-01D9A3A27259"),
                    FeatureId = Guid.Parse("be392eff-ef38-4039-94ec-7922f315ea6a"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("95CF0585-B940-4AFB-926D-01D9A3A27259"),
                    FeatureId = Guid.Parse("182612c2-4fbf-46d9-bee0-9e1a10c29ff5"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("95CF0585-B940-4AFB-926D-01D9A3A27259"),
                    FeatureId = Guid.Parse("4481e46d-e85b-4870-a210-cdfea8932641"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("95CF0585-B940-4AFB-926D-01D9A3A27259"),
                    FeatureId = Guid.Parse("25814c9e-4ee4-4f36-a973-44cf0cf64485"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("95CF0585-B940-4AFB-926D-01D9A3A27259"),
                    FeatureId =  Guid.Parse("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("95CF0585-B940-4AFB-926D-01D9A3A27259"),
                    FeatureId = Guid.Parse("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("95CF0585-B940-4AFB-926D-01D9A3A27259"),
                    FeatureId = Guid.Parse("905d9d8f-7b09-4536-82d1-d15b938b2dac"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("95CF0585-B940-4AFB-926D-01D9A3A27259"),
                    FeatureId = Guid.Parse("defbc09e-9f00-49b9-a37e-592a17cecc63"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("95CF0585-B940-4AFB-926D-01D9A3A27259"),
                    FeatureId = Guid.Parse("06653486-dec4-4054-ba49-c3a63490453e"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("95CF0585-B940-4AFB-926D-01D9A3A27259"),
                    FeatureId = Guid.Parse("057670f0-ab14-41bf-b5f0-42c0bdcc069c"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("95CF0585-B940-4AFB-926D-01D9A3A27259"),
                    FeatureId = Guid.Parse("f761d066-304f-49f7-b988-3aca64536d9b"),
                },

                //car 3
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                    FeatureId =  Guid.Parse("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                    FeatureId =  Guid.Parse("533a7038-190b-4830-8125-5d2aacb7174e")
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                    FeatureId =  Guid.Parse("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                    FeatureId =  Guid.Parse("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                    FeatureId =  Guid.Parse("be392eff-ef38-4039-94ec-7922f315ea6a"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                    FeatureId =  Guid.Parse("182612c2-4fbf-46d9-bee0-9e1a10c29ff5"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                    FeatureId =  Guid.Parse("e285ec6a-3119-43b5-8edb-209fa732a77d"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                    FeatureId =  Guid.Parse("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                    FeatureId =  Guid.Parse("4481e46d-e85b-4870-a210-cdfea8932641"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                    FeatureId = Guid.Parse("25814c9e-4ee4-4f36-a973-44cf0cf64485"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                    FeatureId =  Guid.Parse("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1")
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                    FeatureId =  Guid.Parse("59df0181-9f39-4f9c-b41f-2a0f3d6360d0")
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                    FeatureId = Guid.Parse("905d9d8f-7b09-4536-82d1-d15b938b2dac")
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                    FeatureId = Guid.Parse("defbc09e-9f00-49b9-a37e-592a17cecc63"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                    FeatureId =  Guid.Parse("06653486-dec4-4054-ba49-c3a63490453e"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                    FeatureId =  Guid.Parse("057670f0-ab14-41bf-b5f0-42c0bdcc069c"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("C0EE3730-2717-4F50-8294-CF13437BBC2B"),
                    FeatureId =  Guid.Parse("f761d066-304f-49f7-b988-3aca64536d9b"),
                },

                // car 4
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("8705F403-06BC-4983-8C81-86310959CC37"),
                    FeatureId =  Guid.Parse("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("8705F403-06BC-4983-8C81-86310959CC37"),
                    FeatureId =  Guid.Parse("533a7038-190b-4830-8125-5d2aacb7174e"),
                },

                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("8705F403-06BC-4983-8C81-86310959CC37"),
                    FeatureId =  Guid.Parse("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("8705F403-06BC-4983-8C81-86310959CC37"),
                    FeatureId =   Guid.Parse("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1")
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("8705F403-06BC-4983-8C81-86310959CC37"),
                    FeatureId =   Guid.Parse("905d9d8f-7b09-4536-82d1-d15b938b2dac")
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("8705F403-06BC-4983-8C81-86310959CC37"),
                    FeatureId =   Guid.Parse("defbc09e-9f00-49b9-a37e-592a17cecc63"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("8705F403-06BC-4983-8C81-86310959CC37"),
                    FeatureId =   Guid.Parse("06653486-dec4-4054-ba49-c3a63490453e"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("8705F403-06BC-4983-8C81-86310959CC37"),
                    FeatureId = Guid.Parse("057670f0-ab14-41bf-b5f0-42c0bdcc069c"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("8705F403-06BC-4983-8C81-86310959CC37"),
                    FeatureId = Guid.Parse("f761d066-304f-49f7-b988-3aca64536d9b"),
                },

                //car 5 
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("7AC71700-7A87-45B6-9120-19D4ED3933FA"),
                    FeatureId =  Guid.Parse("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("7AC71700-7A87-45B6-9120-19D4ED3933FA"),
                    FeatureId =   Guid.Parse("533a7038-190b-4830-8125-5d2aacb7174e"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("7AC71700-7A87-45B6-9120-19D4ED3933FA"),
                    FeatureId =   Guid.Parse("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("7AC71700-7A87-45B6-9120-19D4ED3933FA"),
                    FeatureId = Guid.Parse("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("7AC71700-7A87-45B6-9120-19D4ED3933FA"),
                    FeatureId = Guid.Parse("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("7AC71700-7A87-45B6-9120-19D4ED3933FA"),
                    FeatureId = Guid.Parse("4481e46d-e85b-4870-a210-cdfea8932641"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("7AC71700-7A87-45B6-9120-19D4ED3933FA"),
                    FeatureId = Guid.Parse("25814c9e-4ee4-4f36-a973-44cf0cf64485"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("7AC71700-7A87-45B6-9120-19D4ED3933FA"),
                    FeatureId = Guid.Parse("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("7AC71700-7A87-45B6-9120-19D4ED3933FA"),
                    FeatureId = Guid.Parse("905d9d8f-7b09-4536-82d1-d15b938b2dac"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("7AC71700-7A87-45B6-9120-19D4ED3933FA"),
                    FeatureId = Guid.Parse("defbc09e-9f00-49b9-a37e-592a17cecc63"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("7AC71700-7A87-45B6-9120-19D4ED3933FA"),
                    FeatureId =  Guid.Parse("057670f0-ab14-41bf-b5f0-42c0bdcc069c"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("7AC71700-7A87-45B6-9120-19D4ED3933FA"),
                    FeatureId =  Guid.Parse("f761d066-304f-49f7-b988-3aca64536d9b"),
                },

                //car 6
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                    FeatureId =  Guid.Parse("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                    FeatureId =  Guid.Parse("533a7038-190b-4830-8125-5d2aacb7174e"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                    FeatureId =  Guid.Parse("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                    FeatureId = Guid.Parse("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                    FeatureId = Guid.Parse("be392eff-ef38-4039-94ec-7922f315ea6a"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                    FeatureId = Guid.Parse("182612c2-4fbf-46d9-bee0-9e1a10c29ff5"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                    FeatureId =  Guid.Parse("e285ec6a-3119-43b5-8edb-209fa732a77d"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                    FeatureId =  Guid.Parse("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                    FeatureId = Guid.Parse("4481e46d-e85b-4870-a210-cdfea8932641"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                    FeatureId = Guid.Parse("25814c9e-4ee4-4f36-a973-44cf0cf64485"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                    FeatureId = Guid.Parse("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                    FeatureId = Guid.Parse("6ebf1d36-35fa-4cad-9d6f-671476d02020"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                    FeatureId = Guid.Parse("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                    FeatureId = Guid.Parse("905d9d8f-7b09-4536-82d1-d15b938b2dac"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                    FeatureId = Guid.Parse("defbc09e-9f00-49b9-a37e-592a17cecc63"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                    FeatureId = Guid.Parse("06653486-dec4-4054-ba49-c3a63490453e"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                    FeatureId = Guid.Parse("057670f0-ab14-41bf-b5f0-42c0bdcc069c"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("E9743276-25FD-4B47-A8AC-BE13F27D2A53"),
                    FeatureId = Guid.Parse("f761d066-304f-49f7-b988-3aca64536d9b"),
                },

                 //Car 7 
                 //Debt
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("1E83D72D-AD11-4F9F-B342-B39A2EF7A2F8"),
                    FeatureId =  Guid.Parse("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("1E83D72D-AD11-4F9F-B342-B39A2EF7A2F8"),
                    FeatureId = Guid.Parse("533a7038-190b-4830-8125-5d2aacb7174e"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("1E83D72D-AD11-4F9F-B342-B39A2EF7A2F8"),
                    FeatureId =  Guid.Parse("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("1E83D72D-AD11-4F9F-B342-B39A2EF7A2F8"),
                    FeatureId =   Guid.Parse("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("1E83D72D-AD11-4F9F-B342-B39A2EF7A2F8"),
                    FeatureId =  Guid.Parse("be392eff-ef38-4039-94ec-7922f315ea6a"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("1E83D72D-AD11-4F9F-B342-B39A2EF7A2F8"),
                    FeatureId = Guid.Parse("182612c2-4fbf-46d9-bee0-9e1a10c29ff5"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("1E83D72D-AD11-4F9F-B342-B39A2EF7A2F8"),
                    FeatureId = Guid.Parse("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("1E83D72D-AD11-4F9F-B342-B39A2EF7A2F8"),
                    FeatureId = Guid.Parse("4481e46d-e85b-4870-a210-cdfea8932641"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("1E83D72D-AD11-4F9F-B342-B39A2EF7A2F8"),
                    FeatureId = Guid.Parse("25814c9e-4ee4-4f36-a973-44cf0cf64485"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("1E83D72D-AD11-4F9F-B342-B39A2EF7A2F8"),
                    FeatureId = Guid.Parse("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("1E83D72D-AD11-4F9F-B342-B39A2EF7A2F8"),
                    FeatureId =  Guid.Parse("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("1E83D72D-AD11-4F9F-B342-B39A2EF7A2F8"),
                    FeatureId =  Guid.Parse("defbc09e-9f00-49b9-a37e-592a17cecc63"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("1E83D72D-AD11-4F9F-B342-B39A2EF7A2F8"),
                    FeatureId = Guid.Parse("06653486-dec4-4054-ba49-c3a63490453e"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("1E83D72D-AD11-4F9F-B342-B39A2EF7A2F8"),
                    FeatureId = Guid.Parse("057670f0-ab14-41bf-b5f0-42c0bdcc069c"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("1E83D72D-AD11-4F9F-B342-B39A2EF7A2F8"),
                    FeatureId =  Guid.Parse("f761d066-304f-49f7-b988-3aca64536d9b"),
                },
                //car 8
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("06ED14A0-A17E-48D8-868F-33CF5CE916AA"),
                    FeatureId =  Guid.Parse("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("06ED14A0-A17E-48D8-868F-33CF5CE916AA"),
                    FeatureId =  Guid.Parse("533a7038-190b-4830-8125-5d2aacb7174e"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("06ED14A0-A17E-48D8-868F-33CF5CE916AA"),
                    FeatureId =  Guid.Parse("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("06ED14A0-A17E-48D8-868F-33CF5CE916AA"),
                    FeatureId =  Guid.Parse("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("06ED14A0-A17E-48D8-868F-33CF5CE916AA"),
                    FeatureId = Guid.Parse("4481e46d-e85b-4870-a210-cdfea8932641"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("06ED14A0-A17E-48D8-868F-33CF5CE916AA"),
                    FeatureId =  Guid.Parse("25814c9e-4ee4-4f36-a973-44cf0cf64485"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("06ED14A0-A17E-48D8-868F-33CF5CE916AA"),
                    FeatureId = Guid.Parse("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("06ED14A0-A17E-48D8-868F-33CF5CE916AA"),
                    FeatureId = Guid.Parse("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("06ED14A0-A17E-48D8-868F-33CF5CE916AA"),
                    FeatureId =  Guid.Parse("905d9d8f-7b09-4536-82d1-d15b938b2dac"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("06ED14A0-A17E-48D8-868F-33CF5CE916AA"),
                    FeatureId = Guid.Parse("defbc09e-9f00-49b9-a37e-592a17cecc63"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("06ED14A0-A17E-48D8-868F-33CF5CE916AA"),
                    FeatureId = Guid.Parse("06653486-dec4-4054-ba49-c3a63490453e"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("06ED14A0-A17E-48D8-868F-33CF5CE916AA"),
                    FeatureId = Guid.Parse("057670f0-ab14-41bf-b5f0-42c0bdcc069c"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("06ED14A0-A17E-48D8-868F-33CF5CE916AA"),
                    FeatureId = Guid.Parse("f761d066-304f-49f7-b988-3aca64536d9b"),
                },
                //car 9
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =  Guid.Parse("D2DA81D0-8F87-43CB-9DBA-1A0903C1871A"),
                    FeatureId = Guid.Parse("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("D2DA81D0-8F87-43CB-9DBA-1A0903C1871A"),
                    FeatureId =  Guid.Parse("533a7038-190b-4830-8125-5d2aacb7174e")
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("D2DA81D0-8F87-43CB-9DBA-1A0903C1871A"),
                    FeatureId =  Guid.Parse("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =Guid.Parse("D2DA81D0-8F87-43CB-9DBA-1A0903C1871A"),
                    FeatureId =  Guid.Parse("be392eff-ef38-4039-94ec-7922f315ea6a"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =Guid.Parse("D2DA81D0-8F87-43CB-9DBA-1A0903C1871A"),
                    FeatureId = Guid.Parse("182612c2-4fbf-46d9-bee0-9e1a10c29ff5"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("D2DA81D0-8F87-43CB-9DBA-1A0903C1871A"),
                    FeatureId = Guid.Parse("e285ec6a-3119-43b5-8edb-209fa732a77d"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =Guid.Parse("D2DA81D0-8F87-43CB-9DBA-1A0903C1871A"),
                    FeatureId =Guid.Parse("4481e46d-e85b-4870-a210-cdfea8932641"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =Guid.Parse("D2DA81D0-8F87-43CB-9DBA-1A0903C1871A"),
                    FeatureId = Guid.Parse("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("D2DA81D0-8F87-43CB-9DBA-1A0903C1871A"),
                    FeatureId =Guid.Parse("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =Guid.Parse("D2DA81D0-8F87-43CB-9DBA-1A0903C1871A"),
                    FeatureId = Guid.Parse("905d9d8f-7b09-4536-82d1-d15b938b2dac"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("D2DA81D0-8F87-43CB-9DBA-1A0903C1871A"),
                    FeatureId =  Guid.Parse("defbc09e-9f00-49b9-a37e-592a17cecc63"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("D2DA81D0-8F87-43CB-9DBA-1A0903C1871A"),
                    FeatureId =Guid.Parse("057670f0-ab14-41bf-b5f0-42c0bdcc069c"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("D2DA81D0-8F87-43CB-9DBA-1A0903C1871A"),
                    FeatureId =  Guid.Parse("f761d066-304f-49f7-b988-3aca64536d9b"),
                },

                ///car 10 
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("35FA8298-81A2-4DDD-9312-0876455BF402"),
                    FeatureId =  Guid.Parse("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("35FA8298-81A2-4DDD-9312-0876455BF402"),
                    FeatureId =   Guid.Parse("533a7038-190b-4830-8125-5d2aacb7174e"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =Guid.Parse("35FA8298-81A2-4DDD-9312-0876455BF402"),
                    FeatureId =  Guid.Parse("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("35FA8298-81A2-4DDD-9312-0876455BF402"),
                    FeatureId = Guid.Parse("25814c9e-4ee4-4f36-a973-44cf0cf64485"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =Guid.Parse("35FA8298-81A2-4DDD-9312-0876455BF402"),
                    FeatureId = Guid.Parse("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =Guid.Parse("35FA8298-81A2-4DDD-9312-0876455BF402"),
                    FeatureId = Guid.Parse("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId = Guid.Parse("35FA8298-81A2-4DDD-9312-0876455BF402"),
                    FeatureId =  Guid.Parse("defbc09e-9f00-49b9-a37e-592a17cecc63"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =Guid.Parse("35FA8298-81A2-4DDD-9312-0876455BF402"),
                    FeatureId = Guid.Parse("06653486-dec4-4054-ba49-c3a63490453e"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =Guid.Parse("35FA8298-81A2-4DDD-9312-0876455BF402"),
                    FeatureId =Guid.Parse("057670f0-ab14-41bf-b5f0-42c0bdcc069c"),
                },
                new CarFeature
                {
                    CarFeatureId = Guid.NewGuid(),
                    CarId =Guid.Parse("35FA8298-81A2-4DDD-9312-0876455BF402"),
                    FeatureId =  Guid.Parse("f761d066-304f-49f7-b988-3aca64536d9b"),
                },

            });
        }
    }
}
