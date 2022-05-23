<script setup>

import {useNavigation} from "~/stores/navigation";

const navigationStore = useNavigation();

const isCollapsed = computed(() => {
  return navigationStore.isCollapsed;
})


</script>

<template>
  <li class="font-medium text-lg text-gray-50">
    <NuxtLink :class="[activeLink, collapsedLink]"  :to="linkItem.href"
              class="flex items-center gap-2.5 p-4 rounded transition duration-300 ease-in-out hover:text-gray-900 hover:bg-gray-200">
      <span :style="`color: ${linkItem.color}`" :class="linkItem.icon"></span>
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
