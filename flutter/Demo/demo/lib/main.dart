import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'model.dart';
import 'screen.dart';

void main() {
  runApp(
    ChangeNotifierProvider(
      create: (context) => CartModel(),
      child: MyApp(),
    ),
  );
}

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Demo Giỏ hàng',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      initialRoute: '/',
      routes: {
        '/': (context) => ProductScreen(),
        '/cart': (context) => CartScreen(),
      },
    );
  }
}
