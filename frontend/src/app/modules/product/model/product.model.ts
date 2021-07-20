export class Product {
    id?: string;
    name?: string;
    description?: string;
    photoUri?: string;
    price: number = 0;
}

export class CartProduct {
    product?: Product;
    quantity: number = 1;

    get amount(): number {
        let price = this.product?.price || 0;
        return this.quantity * price;
    }
}