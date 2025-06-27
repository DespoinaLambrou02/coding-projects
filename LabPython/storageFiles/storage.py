
from storageFiles.product import Product


class Storage():
    def __init__(self):
        self.productList = []

    def add_product(self, product):
        if self.productList:
            for i in range(0, len(self.productList)):
                if product.id == self.productList[i].id:
                    print(f"The product with this id:{product.id} already exists")
                    return
            self.productList.append(product)
            print("The product was added")

        else:
            self.productList.append(product)
            print("The product was added")

    def search_product_byID(self, id):
        for i in range(0, len(self.productList)):
            if id == self.productList[i].id:
                return self.productList[i]
        return None

    def remove_product(self, productID):
        delProduct = self.search_product_byID(productID)
        if delProduct:
            self.productList.remove(delProduct)
            print("The product was removed")
        else:
            print("The product you are trying to remove does not exist")

    def display_inventory(self):
        if self.productList:
            for product in self.productList:
                print(
                    f"ID:{product.id} - name:{product.name} - price per product:{product.price} - quantity:{product.quantity} ")
        else:
            print("There are no products on the catalog")

    def search_product(self, productName):
        listOfSearch = []
        for product in self.productList:
            if productName in product.name:
                listOfSearch.append(product)
        if listOfSearch:
            return listOfSearch
        else:
            print("No product with this name was found")
            return []

    def update_product(self, productID, productPrice, productQuantity):
        uppProduct = self.search_product_byID(productID)
        if uppProduct:
            uppProduct.price = productPrice
            uppProduct.quantity = productQuantity
            print("The product was updated")
        else:
            print("The product you are trying to uppdate does not exist")

    def calculate_total_value(self):

        total = 0
        for product in self.productList:
            value = product.price * product.quantity
            total = total + value
        print(total)

    def save_to_file(self):
        try:
            with open ("productCatalog.txt", "w") as file:
                for product in self.productList:
                    file.write(f"ID: {product.id} - name: {product.name} - price: {product.price} - quantity: {product.quantity}\n")
                print("the file was saved")

        except Exception as e:
            print("The method failed try again")

    def load_from_file(self):
        try:
            with open("productCatalog.txt", "r") as file:
                self.productList = []
                for line in file:
                    productFields = line.strip().split(" - ")
                    try:
                        idProduct = int(productFields[0].split(": ")[1])
                        priceProduct = int(productFields[2].split(": ")[1])
                        quantityProduct = int(productFields[3].split(": ")[1])
                        nameProduct = productFields[1].split(": ")[1]
                        p2 = Product(idProduct, nameProduct, priceProduct, quantityProduct)
                        self.productList.append(p2)
                    except Exception as e:
                        print("the data of the txt file are not correct")
            print("The file was loaded")
        except Exception as e:
            print("The file does not exist please create it first with function 7")





