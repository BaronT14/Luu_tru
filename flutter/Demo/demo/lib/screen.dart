import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'model.dart';

class ProductScreen extends StatelessWidget {
  final List<String> products = ['Sản phẩm 1', 'Sản phẩm 2', 'Sản phẩm 3'];

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Danh sách sản phẩm'),
        actions: [
          IconButton(
            icon: Icon(Icons.shopping_cart),
            onPressed: () {
              Navigator.pushNamed(context, '/cart');
            },
          )
        ],
      ),
      body: ListView.builder(
        itemCount: products.length,
        itemBuilder: (context, index) {
          final product = products[index];
          // Sử dụng Provider để kiểm tra xem sản phẩm đã được thêm vào giỏ chưa
          return Consumer<CartModel>(
            builder: (context, cart, child) {
              final isInCart = cart.items.contains(product);
              return ListTile(
                title: Text(product),
                trailing: ElevatedButton(
                  // Nếu sản phẩm đã có trong giỏ, đổi nút thành "Đã thêm"
                  style: ElevatedButton.styleFrom(
                    backgroundColor: isInCart ? Colors.grey : Colors.blue,
                  ),
                  child: Text(isInCart ? 'Đã thêm' : 'Thêm vào giỏ'),
                  onPressed: isInCart
                      ? null // Vô hiệu hóa nút nếu đã thêm vào giỏ
                      : () {
                          Provider.of<CartModel>(context, listen: false)
                              .addItem(product);
                        },
                ),
              );
            },
          );
        },
      ),
    );
  }
}


class CartScreen extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text('Giỏ hàng')),
      body: Consumer<CartModel>(
        builder: (context, cart, child) {
          return ListView.builder(
            itemCount: cart.itemCount,
            itemBuilder: (context, index) {
              final product = cart.items[index];
              return ListTile(
                title: Text(product),
                trailing: IconButton(
                  icon: Icon(Icons.remove_circle_outline),
                  onPressed: () {
                    Provider.of<CartModel>(context, listen: false)
                        .removeItem(product);
                  },
                ),
              );
            },
          );
        },
      ),
    );
  }
}