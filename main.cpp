#include <iostream>

#include "utilities.h"

int main()
{
    println(concatStrings(concatStrings(programInfo.NAME, " v"), programInfo.VERSION));
    return 0;
}
