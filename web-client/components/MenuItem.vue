<script setup>

import {useNavigation} from "~/stores/navigation";

const navigationStore = useNavigation();

const sidebar = {
  navigationLists: [
    {
      name: "Hoved",
      ariaLabel: "Sidebar Hoved",
      items: [
        {id: 0, href: '/', icon: 'ri-home-line', text: 'Oversikt'},
        {id: 1, href: '/stillinger', icon: 'ri-briefcase-3-line', text: 'Stillinger'},
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

</script>

<template>
  <li class="font-medium text-lg text-gray-50">
    <NuxtLink :class="[activeLink, collapsedLink]" :to="linkItem.href"
              class="flex items-center gap-2.5 p-4 rounded transition duration-300 ease-in-out hover:text-gray-900 hover:bg-gray-200">
      <span :class="linkItem.icon"></span>
      <div v-if="!isCollapsed" class="">
        <p>{{ linkItem.text }}</p>
      </div>
    </NuxtLink>
  </li>
</template>

<script>
export default {
  props: {
    linkItem: Object
  },
  computed: {
    activeLink() {
      return this.$route.path == this.linkItem.href ? 'bg-gray-100 text-black' : '';
    },
    collapsedLink() {
      return false ? 'justify-center' : '';
    }
  }
}
</script>
