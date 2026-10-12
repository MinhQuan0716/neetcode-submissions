public class StockSpanner {
    Stack<(int price, int span)> stock;
    public StockSpanner() {
        stock = new Stack<(int price,int span)>();
    }
    
    public int Next(int price) {
       int span = 1;
       while(stock.Count>0 && stock.Peek().price <= price){
          span += stock.Pop().span;
       }
        stock.Push((price, span));
        return span;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */