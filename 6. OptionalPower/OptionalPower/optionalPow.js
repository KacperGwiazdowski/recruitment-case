function optionalPow(a,b)
{
    if (confirm("!")) {
        return Math.pow(a,b);
      } else {
        return Math.pow(b,a);
      }
}