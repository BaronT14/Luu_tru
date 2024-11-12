import 'package:flutter/material.dart';

class CartModel with ChangeNotifier {
  final List<String> _items = [];

  List<String> get items => _items;

  // Thêm sản phẩm vào giỏ
  void addItem(String item) {
    _items.add(item);
    notifyListeners();
  }

  // Xóa sản phẩm khỏi giỏ
  void removeItem(String item) {
    _items.remove(item);
    notifyListeners();
  }

  // Đếm số sản phẩm trong giỏ
  int get itemCount => _items.length;
}
