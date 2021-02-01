using HealthyANDTastyModel;
using System;

namespace HealthyANDTastyDAL.Repositories
{
    public class UnitOfWork : IDisposable
    {
        #region Private Attributes
        private HealthyANDTastyEntities healthyANDTastyEntities;
        private AdminRepository adminRepository;
        private UserRepository userRepository;
        private DietRepository dietRepository;
        private MealRepository mealRepository;
        private OrderRepository orderRepository;
        private BellRepository bellRepository;
        #endregion

        #region Constructor
        public UnitOfWork() 
        {
            this.healthyANDTastyEntities = new HealthyANDTastyEntities();
        }
        #endregion

        #region Public Functions
        public void Commit()
        {
            healthyANDTastyEntities.SaveChanges();
        }
        public void Dispose()
        {
           if( healthyANDTastyEntities!=null)
                healthyANDTastyEntities.Dispose();
        }
        #endregion

        #region Public Attributes
        public AdminRepository AdminRepository
        {
            get
            {
                return adminRepository ?? (adminRepository = new AdminRepository(healthyANDTastyEntities));
            }
        }
        public UserRepository UserRepository
        {
            get
            {
                return userRepository ?? (userRepository = new UserRepository(healthyANDTastyEntities));
            }
        }
        public DietRepository DietRepository
        {
            get
            {
                return dietRepository ?? (dietRepository = new DietRepository(healthyANDTastyEntities));
            }
        }
        public MealRepository MealRepository
        {
            get
            {
                return mealRepository ?? (mealRepository = new MealRepository(healthyANDTastyEntities));
            }
        }
        public OrderRepository OrderRepository
        {
            get
            {
                return orderRepository ?? (orderRepository = new OrderRepository(healthyANDTastyEntities));
            }
        }
        public BellRepository BellRepository
        {
            get
            {
                return bellRepository ?? (bellRepository = new BellRepository(healthyANDTastyEntities));
            }
        }
        #endregion
    }
}
