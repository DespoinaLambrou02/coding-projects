from logging import exception

from storage import  Storage
from product import Product




theStorage = Storage()
continueOrNot = True
while continueOrNot:
    checkValue = True
    while checkValue:
        print('''
    choose one of the following options
    1) add a product to the catalog 
    2) remove a product from the catalog by their id
    3) display all the product of the catalog
    4) search a product based on ther name
    5) Update the value and the quantity of a product based on the id
    6) Calculate the total value of the stock in the storage
    7) Save the product list in a file
    8) Load the catalog from an existing file
    ''')
        inputNum = input("place your answer with a number")
        try:
            number = int(inputNum)
        except Exception as e:
            print("you did not give a number between 1 and 8")
            continue
        if number >=1 and number<=8:
            checkValue = False
        else:
            print("you did not give a number between 1 and 8")
            continue




    checkValue = True
    while checkValue:
        if number == 1:
            try:
                idProduct = int(input("Give a id for the product"))
            except Exception as e:
                print("you did not give a number for id")
                continue
            try:
                priceProduct = int(input("Give a price for the product"))
            except Exception as e:
                print("you did not give a number for price")
                continue
            try:
                quantityProduct = int(input("Give quantity for the product"))
                checkValue = False
            except Exception as e:
                print("you did not give a number for quantity")
                continue
            nameProduct = input("give a name for the product")
            p1 = Product(idProduct, nameProduct, priceProduct, quantityProduct)
            theStorage.add_product(p1)
        elif number == 2:
            try:
                idProduct = int(input("Give the id for the product"))
            except Exception as e:
                print("you did not give a number for id")
                continue
            theStorage.remove_product(idProduct)
            checkValue = False
        elif number == 3:
            theStorage.display_inventory()
            checkValue = False
        elif number == 4:
            nameProduct = input("give the name for the product")
            theList = theStorage.search_product(nameProduct)
            for product in theList:
                print(f"ID:{product.id} - name:{product.name} - price per product:{product.price} - quantity:{product.quantity}")
            checkValue = False
        elif number == 5:
            try:
                idProduct = int(input("Give the id for the product"))
            except Exception as e:
                print("you did not give a number for id")
                continue
            try:
                priceProduct = int(input("Give the new price for the product"))
            except Exception as e:
                print("you did not give a number for price")
                continue
            try:
                quantityProduct = int(input("Give the new quantity for the product"))
                checkValue = False
            except Exception as e:
                print("you did not give a number for quantity")
                continue
            theStorage.update_product(idProduct,priceProduct,quantityProduct)
            checkValue = False
        elif number == 6:
            theStorage.calculate_total_value()
            checkValue = False
        elif number == 7:
            theStorage.save_to_file()
            checkValue = False
        elif number == 8:
            theStorage.load_from_file()
            checkValue = False






    answer = True
    while answer:
        try:
            yesOrNo = int(input(f'''
            please give 1
            if you want to continue
            and give 2 if you want
            to stop
                        '''))
        except Exception as e:
            print("You did not give one of the correct options")
        if yesOrNo == 1 or yesOrNo == 2:
            answer = False
        else:
            print("you did not gave a number 1 or 2, try again")





    if yesOrNo == 2:
        continueOrNot = False
















