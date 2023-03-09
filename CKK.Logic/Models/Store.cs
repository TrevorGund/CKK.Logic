namespace CKK.Logic.Models
{
    class Store
    {
        private int _id;
        private string _name;
        private Product Product1;
        private Product Product2;
        private Product Product3;

        public int GetId()
        {
            return _id;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }


        public void AddStoreItem(Product prod)
        {
            if (Product1 == null)
            {
                Product1 = prod;
            }
            else if (Product2 == null)
            {
                Product2 = prod;
            }
            else if (Product3 == null)
            {
                Product3 = prod;
            }
            else if (Product3 != null)
            {
                Product3 = prod;
            }
        }
        public void RemoveStoreItem(int productNumber)
        {
            if (productNumber == 1)
            {
                Product1 = null;
            }
            else if (productNumber == 2)
            {
                Product2 = null;
            }
            else if (productNumber == 3)
            {
                Product3 = null;
            }
        }
        public Product GetStoreItem(int productNumber)
        {
            if (productNumber == 1)
            {
                return Product1;
            }
            else if (productNumber == 2)
            {
                return Product2;
            }
            else if (productNumber == 3)
            {
                return Product3;
            }
            else
            {
                return null;
            }
        }
             
        public Product FindStoreItemById(int id)
        {
            if(id == Product1._id)
            {
                return Product1;
            }
            else if(id == Product2._id)
            {
                return Product2;
            }
            else if(id == Product3._id)
            {
                return Product3;
            }
            else
            {
                return null;
            }
        }
    }

}