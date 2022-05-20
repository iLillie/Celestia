<script lang="ts" setup>
import {useNavigation} from "~/stores/navigation";

const navigationStore = useNavigation();

const sidebar = {
  navigationLists: [
    {
      name: "Hoved",
      ariaLabel: "Sidebar Hoved",
      items: [
        {id: 0, href: '/', icon: 'ri-home-line', text: 'Oversikt'},
        {id: 1, href: '/jobber', icon: 'ri-briefcase-3-line', text: 'Jobber'},
        {id: 2, href: '/selskaper', icon: 'ri-building-2-line', text: 'Selskaper'},
        {id: 3, href: '/kontakter', icon: 'ri-contacts-book-2-line', text: 'Kontakter'},
      ]
    },
    {
      name: "Favoritter",
      ariaLabel: "Sidebar Favoritter",
      items: [
        {id: 4, href: '/frontend', icon: 'ri-folder-open-line', text: 'Frontend'},
        {id: 5, href: '/backend', icon: 'ri-folder-open-line', text: 'Backend'},
        {id: 6, href: '/full', icon: 'ri-folder-open-line', text: 'Full-Stack'},
      ]
    },
  ],
}

const changeState = () => {
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
         class="nav-color h-screen shadow-md p-4  flex flex-col gap-8 overflow-y-auto sticky top-0">

    <header :class="headerClass" class="flex py-8 px-2 items-center">
      <svg :class="logoClass" aria-label="it jakt" width="148" height="35" viewBox="0 0 148 35" fill="none" xmlns="http://www.w3.org/2000/svg">
        <path d="M23.0293 15.8158C23.0293 19.0456 20.4111 21.6638 17.1813 21.6638C13.9516 21.6638 11.3333 19.0456 11.3333 15.8158V12.6246C11.3333 11.9115 11.9115 11.3333 12.6246 11.3333L21.738 11.3333C22.4512 11.3333 23.0293 11.9115 23.0293 12.6246L23.0293 15.8158Z" fill="#7D9BE8"/>
        <path fill-rule="evenodd" clip-rule="evenodd" d="M26.2976 17H34V30.6C34 32.4778 32.4778 34 30.6 34H3.4C1.52223 34 0 32.4778 0 30.6V17H8.08014C8.85868 21.2961 12.6407 24.5556 17.1889 24.5556C21.7371 24.5556 25.5191 21.2961 26.2976 17Z" fill="white"/>
        <path d="M9.97708 8.31111L24.4007 8.31111C25.5294 8.31111 26.4444 9.22022 26.4444 10.3417V13.6H34V3.4C34 1.52223 32.4778 0 30.6 0H3.4C1.52223 0 0 1.52223 0 3.4V13.6H7.93333L7.93333 10.3417C7.93333 9.22022 8.84835 8.31111 9.97708 8.31111Z" fill="#7D9BE8"/>
        <path d="M49.84 6.9V30H45.01V6.9H49.84ZM62.075 7.145V24.295C62.075 25.135 62.285 25.7533 62.705 26.15C63.1483 26.5233 63.7433 26.71 64.49 26.71C65.0733 26.71 65.5866 26.6283 66.03 26.465C66.4733 26.2783 66.87 26.0333 67.22 25.73L67.99 28.915C67.43 29.3583 66.73 29.7083 65.89 29.965C65.05 30.2217 64.1633 30.35 63.23 30.35C62.0633 30.35 61.025 30.175 60.115 29.825C59.2283 29.475 58.5283 28.915 58.015 28.145C57.525 27.375 57.28 26.3483 57.28 25.065V8.475L62.075 7.145ZM67.675 12.5V16.07H54.06V12.5H67.675Z" fill="white"/>
        <path d="M87.229 6.9V21.495C87.229 24.2717 86.4474 26.4417 84.884 28.005C83.3207 29.5683 81.104 30.35 78.234 30.35C76.1807 30.35 74.5124 29.9767 73.229 29.23C71.9457 28.4833 71.059 27.4333 70.569 26.08C70.079 24.7267 69.9857 23.175 70.289 21.425L74.979 20.585C74.699 22.6383 74.8274 24.12 75.364 25.03C75.9007 25.94 76.8924 26.395 78.339 26.395C79.8557 26.395 80.9057 25.9283 81.489 24.995C82.0957 24.0617 82.399 22.6733 82.399 20.83V6.9H87.229ZM102.52 18.835C102.52 17.8317 102.229 17.05 101.645 16.49C101.085 15.93 100.339 15.65 99.4052 15.65C98.5419 15.65 97.7835 15.8717 97.1302 16.315C96.4769 16.7583 95.9985 17.4933 95.6952 18.52L91.6002 17.26C91.9969 15.72 92.8602 14.4833 94.1902 13.55C95.5435 12.6167 97.3519 12.15 99.6152 12.15C101.155 12.15 102.497 12.395 103.64 12.885C104.784 13.3517 105.67 14.0633 106.3 15.02C106.954 15.9767 107.28 17.1783 107.28 18.625V25.73C107.28 26.6167 107.7 27.06 108.54 27.06C108.937 27.06 109.31 27.0017 109.66 26.885L109.38 29.86C108.774 30.1633 108.015 30.315 107.105 30.315C106.289 30.315 105.554 30.175 104.9 29.895C104.247 29.615 103.734 29.195 103.36 28.635C102.987 28.0517 102.8 27.3283 102.8 26.465V26.325L103.64 26.185C103.5 27.0717 103.115 27.83 102.485 28.46C101.855 29.0667 101.085 29.5333 100.175 29.86C99.2885 30.1867 98.3669 30.35 97.4102 30.35C96.2202 30.35 95.1935 30.175 94.3302 29.825C93.4669 29.4517 92.8019 28.915 92.3352 28.215C91.8685 27.515 91.6352 26.6517 91.6352 25.625C91.6352 24.3183 92.0552 23.2567 92.8952 22.44C93.7352 21.6 94.9369 21.0283 96.5002 20.725L103.08 19.395L103.045 22.37L98.8452 23.21C98.0519 23.3733 97.4452 23.595 97.0252 23.875C96.6285 24.1317 96.4302 24.5633 96.4302 25.17C96.4302 25.7533 96.6402 26.1967 97.0602 26.5C97.5035 26.8033 98.0285 26.955 98.6352 26.955C99.1252 26.955 99.6035 26.8967 100.07 26.78C100.537 26.6633 100.957 26.4767 101.33 26.22C101.704 25.9633 101.995 25.6133 102.205 25.17C102.415 24.7267 102.52 24.19 102.52 23.56V18.835ZM130.983 12.5L122.898 20.935L121.953 21.39L116.703 27.025L116.633 21.915L125.523 12.5H130.983ZM117.963 4.835V30H113.168V4.835H117.963ZM123.563 18.065L131.403 30H125.978L120.273 20.865L123.563 18.065ZM140.943 7.145V24.295C140.943 25.135 141.153 25.7533 141.573 26.15C142.016 26.5233 142.611 26.71 143.358 26.71C143.941 26.71 144.454 26.6283 144.898 26.465C145.341 26.2783 145.738 26.0333 146.088 25.73L146.858 28.915C146.298 29.3583 145.598 29.7083 144.758 29.965C143.918 30.2217 143.031 30.35 142.098 30.35C140.931 30.35 139.893 30.175 138.983 29.825C138.096 29.475 137.396 28.915 136.883 28.145C136.393 27.375 136.148 26.3483 136.148 25.065V8.475L140.943 7.145ZM146.543 12.5V16.07H132.928V12.5H146.543Z" fill="#7D9BE8"/>
      </svg>
      <IconButton class="text-gray-900" :aria-expanded="(!isCollapsed).toString()" aria-controls="sidebar" aria-label="Expand sidebar"
                  icon="ri-menu-line" @onClick="changeState()"/>
    </header>

    <nav aria-label="sidebar" class="flex flex-col gap-8">
      <div v-for="navigationList in sidebar.navigationLists">
        <p :class="nameClass" class="font-semibold px-4 py-2 text-gray-600 hidden">
          {{ navigationList.name }}
        </p>
        <ul class="grid gap-4">
          <MenuItem v-for="item in navigationList.items" :key="item.id" :linkItem="item"/>
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

.nav-color {
  background-color: #434856;
}
</style>
