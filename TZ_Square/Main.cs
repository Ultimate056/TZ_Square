using TZ_Square.Interfaces;

namespace TZ_Square
{
    public static class Main
    {
        public static double? GetSquare(IShape shape)
        {
            if (shape == null) return null;

            return shape.GetSquare();
        }


        // 2 вопрос
        /* 
         * select productName Продукт, isnull(categoryName, 'Категория не определена') Категория from Products
         * left join ProductsCategories pc on pc.idProduct = Products.idProduct
         * left join Categories on Categories.idCategory = pc.idCategory
         * */
    }
}
