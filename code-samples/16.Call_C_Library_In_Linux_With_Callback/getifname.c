#include <stdio.h>
#include <net/if.h>

int getifname(void (*ptr)(char*)) {
    struct if_nameindex *if_nidxs, *intf;

    if_nidxs = if_nameindex();
    if ( if_nidxs != NULL )
    {
        for (intf = if_nidxs; intf->if_index != 0 || intf->if_name != NULL; intf++)
        {
            (*ptr) (intf->if_name);
        }
    }

    return 1;
}
