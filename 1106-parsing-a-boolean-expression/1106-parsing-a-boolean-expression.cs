public class Solution 
{
    private string Laundary(string expr, char opr)
    {
        int index = expr.IndexOf(opr.ToString() + "(");
        expr = (index < 0) ? expr : expr.Remove(index, 2);
        index = expr.LastIndexOf(")");
        expr = (index < 0) ? expr : expr.Remove(index, 1);
        
        return expr;
    }
    
                         // expr1, expr2,...
    private bool ParseOr(string exprs)
    {
        var arr = exprs.Split("),", StringSplitOptions.RemoveEmptyEntries);
		if(arr.Length == 1) arr = exprs.Split(",", StringSplitOptions.RemoveEmptyEntries);
        
        bool ans = false;
        
        foreach(var expr in arr)
        {
            if(expr.StartsWith('!')) ans = ans || ParseNot(Laundary(expr, '!'));

            else if(expr.StartsWith('&')) ans = ans || ParseAnd(Laundary(expr, '&'));

            else if(expr.StartsWith('|')) ans = ans || ParseOr(Laundary(expr, '|'));
            
            else ans = ans || ParseBool(expr);
        }
        
        return ans;
    }
                         // expr1, expr2,...
    private bool ParseAnd(string exprs)
    {
        var arr = exprs.Split("),", StringSplitOptions.RemoveEmptyEntries);
		if(arr.Length == 1) arr = exprs.Split(",", StringSplitOptions.RemoveEmptyEntries);
        
        bool ans = true;
        
        foreach(var expr in arr)
        {
            if(expr.StartsWith('!')) ans = ans && ParseNot(Laundary(expr, '!'));

            else if(expr.StartsWith('&')) ans = ans && ParseAnd(Laundary(expr, '&'));

            else if(expr.StartsWith('|')) ans = ans && ParseOr(Laundary(expr, '|'));
            
            else ans = ans && ParseBool(expr);
        }
        
        return ans;
    }
                         // expr
    private bool ParseNot(string expr)
    {
        if(expr.StartsWith('!')) return !ParseNot(Laundary(expr, '!'));
        
        else if(expr.StartsWith('&')) return !ParseAnd(Laundary(expr, '&'));
        
        else if(expr.StartsWith('|')) return !ParseOr(Laundary(expr, '|'));
        
        return !ParseBool(expr);
    }
                           //"t" || "f"
    private bool ParseBool(string expr) => string.Compare(expr, "t") == 0;
    
    public bool ParseBoolExpr(string expression) 
    {
        if(expression.StartsWith('!')) return ParseNot(Laundary(expression, '!'));
        
        else if(expression.StartsWith('&')) return ParseAnd(Laundary(expression, '&'));
        
        else if(expression.StartsWith('|')) return ParseOr(Laundary(expression, '|'));
        
        return ParseBool(expression);
    }
}