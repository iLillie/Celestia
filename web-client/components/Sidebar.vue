<script setup lang="ts">
import {useNavigation} from "~/stores/navigation";
import {useFolders} from "~/stores/folder";

const navigationStore = useNavigation();
const folderStore = useFolders();

let foldersItems = [];

await folderStore.getAllJFolder();

const folders = folderStore.folders;
let id = 3;

folders.forEach((folder) => {
  id++;
  foldersItems.push({ id: id, href:`/app/folders/${folder.id}`, icon: 'ri-folder-open-fill', text: `${folder.name}`, color: folder.color });
})


let sidebar = computed(() => {
  return {
    navigationLists: [
    {
      name: "Hoved",
      ariaLabel: "Sidebar Hoved",
      items: [
        {id: 0, href: '/app', icon: 'ri-home-fill', text: 'Oversikt'},
        {id: 1, href: '/app/jobber', icon: 'ri-briefcase-3-fill', text: 'Jobber'},
        {id: 2, href: '/app/selskaper', icon: 'ri-building-2-fill', text: 'Selskaper'},
        {id: 3, href: '/app/kontakter', icon: 'ri-contacts-book-2-fill', text: 'Kontakter'},
      ]
    },
    {
      name: "Favoritter",
      ariaLabel: "Sidebar Favoritter",
      items: foldersItems
    },
  ],
  }
})


let changeState = () => {
  navigationStore.update();
}

const isCollapsed = computed(() => {
  return navigationStore.isCollapsed;
})

const sidebarClass = computed(() => {
  return navigationStore.isCollapsed ? 'px-8 w-min' : 'clamped-width';
})

const headerClass = computed(() => {
  return navigationStore.isCollapsed ? 'justify-center' : 'justify-between';
})
const logoClass = computed(() => {
  return navigationStore.isCollapsed ? 'hidden' : '';
})

const nameClass = computed(() => {
  return navigationStore.isCollapsed ? 'text-center px-0' : '';
})



</script>

<template>
  <aside id="sidebar"
         :class="sidebarClass"
         class="bg-portage-50 dark:bg-neutral-800 h-screen p-4 flex flex-col gap-8 overflow-y-auto sticky top-0">

    <header :class="headerClass" class="flex py-2 px-2 items-center">
      <Logo :class="logoClass"/>
      <IconButton class="" :aria-expanded="(!isCollapsed).toString()" aria-controls="sidebar" aria-label="Expand sidebar"
                  icon="ri-menu-line" @onClick="changeState()"/>
    </header>

    <nav aria-label="sidebar" class="flex flex-col gap-8">
      <div v-for="navigationList in sidebar.navigationLists">
        <p :class="nameClass" class="font-semibold px-4 py-2 text-gray-600 hidden">
          {{ navigationList.name }}
        </p>
        <ul class="grid gap-4">
          <MenuItem v-for="item in navigationList.items" :key="item.id" :menu-item="item"/>
        </ul>
      </div>
    </nav>

  </aside>
</template>

<style scoped>
/* is used in computed, but IDE doesn't recognize it */
/* TODO: Add into config? */
.clamped-width {
  width: clamp(14rem, 17vw + 1rem, 20rem);
}
</style>
