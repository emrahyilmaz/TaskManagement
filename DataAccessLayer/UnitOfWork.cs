using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UnitOfWork
    {
        DbContextTransaction _transaction;
        ManagementContext _context;
        public UnitOfWork()
        {
            _context = new ManagementContext();
        }
        public bool ApplyChanges()
        {
            bool isSuccess = false;
            _transaction = _context.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            try
            {
                _context.SaveChanges();
                _transaction.Commit();
                isSuccess = true;
            }
            catch (Exception)
            {
                _transaction.Rollback();
                isSuccess = false;
            }
            finally
            {
                _transaction.Dispose();
            }
            return isSuccess;
            
        }

        private ContactRepository _contaxtRepo;
        public ContactRepository ContactRepository
        {
            get
            {
                if (_contaxtRepo == null)
                    _contaxtRepo = new ContactRepository(_context);
                return _contaxtRepo;
            }
        }
        private CustomerRepository _customerRepository;

        public CustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                    _customerRepository = new CustomerRepository(_context);
                return _customerRepository;
            }
        }
        private EmployeeRepository _employeeRepository;
        public EmployeeRepository EmployeeRepository
        {
            get
            {
                if (_employeeRepository == null)
                    _employeeRepository = new EmployeeRepository(_context);
                return _employeeRepository;
            }
        }
        private ProjectRepository _projectRepository;
        public ProjectRepository ProjectRepository
        {
            get
            {
                if (_projectRepository == null)
                    _projectRepository = new ProjectRepository(_context);
                return _projectRepository;
            }
        }
        private RoleRepository _roleRepository;
        public RoleRepository RoleRepository
        {
            get
            {
                if (_roleRepository == null)
                    _roleRepository = new RoleRepository(_context);
                return _roleRepository;
            }
        }
        private StatusRepository _statusRepository;
        public StatusRepository StatusRepository
        {
            get
            {
                if (_statusRepository == null)
                    _statusRepository = new StatusRepository(_context);
                return _statusRepository;
            }
        }
        private TaskRepository _taskRepository;
        public TaskRepository TaskRepository
        {
            get
            {
                if (_taskRepository == null)
                    _taskRepository = new TaskRepository(_context);
                return _taskRepository;
            }
        }
        private TypeRepository _typeRepository;
        public TypeRepository TypeRepository
        {
            get
            {
                if (_typeRepository == null)
                    _typeRepository = new TypeRepository(_context);
                return _typeRepository;
            }
        }
        private UserRepository _userRepositor;
        public UserRepository UserRepository
        {
            get
            {
                if (_userRepositor == null)
                    _userRepositor = new UserRepository(_context);
                return _userRepositor;
            }
        }
    }
}
