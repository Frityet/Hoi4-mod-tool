//
// Created by frityet on 2021-08-25.
//

#include <iostream>

#include "logging.h"

int print(string msg)
{
    std::cout << msg;

    return 1;
}

int println(string msg)
{
    std::cout << msg << std::endl;

    return 1;
}
